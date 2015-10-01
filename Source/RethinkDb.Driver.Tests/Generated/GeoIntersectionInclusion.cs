




//AUTOGENERATED, DO NOTMODIFY.
//Do not edit this file directly.

#pragma warning disable 1591
// ReSharper disable CheckNamespace

using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using RethinkDb.Driver.Model;
using RethinkDb.Driver.Ast;
using NUnit.Framework;
using RethinkDb.Driver.Tests;

namespace RethinkDb.Driver.Test.Generated {
    [TestFixture]
    public class GeoIntersectionInclusion : GeneratedTest {



        [Test]
        public void YamlTest(){

             TestCounter++;
             
             {
                 //JavaQuery, geo/intersection_inclusion.yaml, #1
                 //ExpectedOriginal: True
                 var expected = true;
                 
                 //Original: r.polygon([1,1], [2,1], [2,2], [1,2]).intersects(r.point(1.5,1.5))
                 var obtained = runOrCatch( r.polygon(Arrays.asList(1, 1), Arrays.asList(2, 1), Arrays.asList(2, 2), Arrays.asList(1, 2)).intersects(r.point(1.5, 1.5)) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, geo/intersection_inclusion.yaml, #2
                 //ExpectedOriginal: False
                 var expected = false;
                 
                 //Original: r.polygon([1,1], [2,1], [2,2], [1,2]).intersects(r.point(2.5,2.5))
                 var obtained = runOrCatch( r.polygon(Arrays.asList(1, 1), Arrays.asList(2, 1), Arrays.asList(2, 2), Arrays.asList(1, 2)).intersects(r.point(2.5, 2.5)) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, geo/intersection_inclusion.yaml, #3
                 //ExpectedOriginal: False
                 var expected = false;
                 
                 //Original: r.polygon([1,1], [2,1], [2,2], [1,2]).polygon_sub(r.polygon([1.1,1.1], [1.9,1.1], [1.9,1.9], [1.1,1.9])).intersects(r.point(1.5,1.5))
                 var obtained = runOrCatch( r.polygon(Arrays.asList(1, 1), Arrays.asList(2, 1), Arrays.asList(2, 2), Arrays.asList(1, 2)).polygonSub(r.polygon(Arrays.asList(1.1, 1.1), Arrays.asList(1.9, 1.1), Arrays.asList(1.9, 1.9), Arrays.asList(1.1, 1.9))).intersects(r.point(1.5, 1.5)) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, geo/intersection_inclusion.yaml, #4
                 //ExpectedOriginal: True
                 var expected = true;
                 
                 //Original: r.polygon([1,1], [2,1], [2,2], [1,2]).polygon_sub(r.polygon([1.1,1.1], [1.9,1.1], [1.9,1.9], [1.1,1.9])).intersects(r.point(1.05,1.05))
                 var obtained = runOrCatch( r.polygon(Arrays.asList(1, 1), Arrays.asList(2, 1), Arrays.asList(2, 2), Arrays.asList(1, 2)).polygonSub(r.polygon(Arrays.asList(1.1, 1.1), Arrays.asList(1.9, 1.1), Arrays.asList(1.9, 1.9), Arrays.asList(1.1, 1.9))).intersects(r.point(1.05, 1.05)) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, geo/intersection_inclusion.yaml, #5
                 //ExpectedOriginal: True
                 var expected = true;
                 
                 //Original: r.polygon([1,1], [2,1], [2,2], [1,2]).intersects(r.point(2,2))
                 var obtained = runOrCatch( r.polygon(Arrays.asList(1, 1), Arrays.asList(2, 1), Arrays.asList(2, 2), Arrays.asList(1, 2)).intersects(r.point(2, 2)) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, geo/intersection_inclusion.yaml, #6
                 //ExpectedOriginal: True
                 var expected = true;
                 
                 //Original: r.polygon([1,1], [2,1], [2,2], [1,2]).intersects(r.point(2,1.5))
                 var obtained = runOrCatch( r.polygon(Arrays.asList(1, 1), Arrays.asList(2, 1), Arrays.asList(2, 2), Arrays.asList(1, 2)).intersects(r.point(2, 1.5)) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, geo/intersection_inclusion.yaml, #7
                 //ExpectedOriginal: True
                 var expected = true;
                 
                 //Original: r.polygon([1,1], [2,1], [2,2], [1,2]).intersects(r.line([1.5,1.5], [2,2]))
                 var obtained = runOrCatch( r.polygon(Arrays.asList(1, 1), Arrays.asList(2, 1), Arrays.asList(2, 2), Arrays.asList(1, 2)).intersects(r.line(Arrays.asList(1.5, 1.5), Arrays.asList(2, 2))) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, geo/intersection_inclusion.yaml, #8
                 //ExpectedOriginal: True
                 var expected = true;
                 
                 //Original: r.polygon([1,1], [2,1], [2,2], [1,2]).intersects(r.line([1.5,1.5], [2,1.5]))
                 var obtained = runOrCatch( r.polygon(Arrays.asList(1, 1), Arrays.asList(2, 1), Arrays.asList(2, 2), Arrays.asList(1, 2)).intersects(r.line(Arrays.asList(1.5, 1.5), Arrays.asList(2, 1.5))) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, geo/intersection_inclusion.yaml, #9
                 //ExpectedOriginal: True
                 var expected = true;
                 
                 //Original: r.polygon([1,1], [2,1], [2,2], [1,2]).polygon_sub(r.polygon([1.1,1.1], [1.9,1.1], [1.9,1.9], [1.1,1.9])).intersects(r.point(1.1,1.1))
                 var obtained = runOrCatch( r.polygon(Arrays.asList(1, 1), Arrays.asList(2, 1), Arrays.asList(2, 2), Arrays.asList(1, 2)).polygonSub(r.polygon(Arrays.asList(1.1, 1.1), Arrays.asList(1.9, 1.1), Arrays.asList(1.9, 1.9), Arrays.asList(1.1, 1.9))).intersects(r.point(1.1, 1.1)) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, geo/intersection_inclusion.yaml, #10
                 //ExpectedOriginal: True
                 var expected = true;
                 
                 //Original: r.polygon([1,1], [2,1], [2,2], [1,2]).polygon_sub(r.polygon([1.1,1.1], [1.9,1.1], [1.9,1.9], [1.1,1.9])).intersects(r.point(1.5,1.1))
                 var obtained = runOrCatch( r.polygon(Arrays.asList(1, 1), Arrays.asList(2, 1), Arrays.asList(2, 2), Arrays.asList(1, 2)).polygonSub(r.polygon(Arrays.asList(1.1, 1.1), Arrays.asList(1.9, 1.1), Arrays.asList(1.9, 1.9), Arrays.asList(1.1, 1.9))).intersects(r.point(1.5, 1.1)) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, geo/intersection_inclusion.yaml, #11
                 //ExpectedOriginal: False
                 var expected = false;
                 
                 //Original: r.polygon([1,1], [2,1], [2,2], [1,2]).intersects(r.line([2,2], [3,3]))
                 var obtained = runOrCatch( r.polygon(Arrays.asList(1, 1), Arrays.asList(2, 1), Arrays.asList(2, 2), Arrays.asList(1, 2)).intersects(r.line(Arrays.asList(2, 2), Arrays.asList(3, 3))) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, geo/intersection_inclusion.yaml, #12
                 //ExpectedOriginal: False
                 var expected = false;
                 
                 //Original: r.polygon([1,1], [2,1], [2,2], [1,2]).intersects(r.line([2,1.5], [3,3]))
                 var obtained = runOrCatch( r.polygon(Arrays.asList(1, 1), Arrays.asList(2, 1), Arrays.asList(2, 2), Arrays.asList(1, 2)).intersects(r.line(Arrays.asList(2, 1.5), Arrays.asList(3, 3))) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, geo/intersection_inclusion.yaml, #13
                 //ExpectedOriginal: True
                 var expected = true;
                 
                 //Original: r.polygon([1,1], [2,1], [2,2], [1,2]).intersects(r.line([1.5,1.5], [3,3]))
                 var obtained = runOrCatch( r.polygon(Arrays.asList(1, 1), Arrays.asList(2, 1), Arrays.asList(2, 2), Arrays.asList(1, 2)).intersects(r.line(Arrays.asList(1.5, 1.5), Arrays.asList(3, 3))) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, geo/intersection_inclusion.yaml, #14
                 //ExpectedOriginal: True
                 var expected = true;
                 
                 //Original: r.polygon([1,1], [2,1], [2,2], [1,2]).intersects(r.polygon([1.2,1.2], [1.8,1.2], [1.8,1.8], [1.2,1.8]))
                 var obtained = runOrCatch( r.polygon(Arrays.asList(1, 1), Arrays.asList(2, 1), Arrays.asList(2, 2), Arrays.asList(1, 2)).intersects(r.polygon(Arrays.asList(1.2, 1.2), Arrays.asList(1.8, 1.2), Arrays.asList(1.8, 1.8), Arrays.asList(1.2, 1.8))) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, geo/intersection_inclusion.yaml, #15
                 //ExpectedOriginal: True
                 var expected = true;
                 
                 //Original: r.polygon([1,1], [2,1], [2,2], [1,2]).intersects(r.polygon([1.5,1.5], [2.5,1.5], [2.5,2.5], [1.5,2.5]))
                 var obtained = runOrCatch( r.polygon(Arrays.asList(1, 1), Arrays.asList(2, 1), Arrays.asList(2, 2), Arrays.asList(1, 2)).intersects(r.polygon(Arrays.asList(1.5, 1.5), Arrays.asList(2.5, 1.5), Arrays.asList(2.5, 2.5), Arrays.asList(1.5, 2.5))) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, geo/intersection_inclusion.yaml, #16
                 //ExpectedOriginal: False
                 var expected = false;
                 
                 //Original: r.polygon([1,1], [2,1], [2,2], [1,2]).polygon_sub(r.polygon([1.1,1.1], [1.9,1.1], [1.9,1.9], [1.1,1.9])).intersects(r.polygon([1.2,1.2], [1.8,1.2], [1.8,1.8], [1.2,1.8]))
                 var obtained = runOrCatch( r.polygon(Arrays.asList(1, 1), Arrays.asList(2, 1), Arrays.asList(2, 2), Arrays.asList(1, 2)).polygonSub(r.polygon(Arrays.asList(1.1, 1.1), Arrays.asList(1.9, 1.1), Arrays.asList(1.9, 1.9), Arrays.asList(1.1, 1.9))).intersects(r.polygon(Arrays.asList(1.2, 1.2), Arrays.asList(1.8, 1.2), Arrays.asList(1.8, 1.8), Arrays.asList(1.2, 1.8))) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, geo/intersection_inclusion.yaml, #17
                 //ExpectedOriginal: False
                 var expected = false;
                 
                 //Original: r.polygon([1,1], [2,1], [2,2], [1,2]).polygon_sub(r.polygon([1.1,1.1], [1.9,1.1], [1.9,1.9], [1.1,1.9])).intersects(r.polygon([1.1,1.1], [1.9,1.1], [1.9,1.9], [1.1,1.9]))
                 var obtained = runOrCatch( r.polygon(Arrays.asList(1, 1), Arrays.asList(2, 1), Arrays.asList(2, 2), Arrays.asList(1, 2)).polygonSub(r.polygon(Arrays.asList(1.1, 1.1), Arrays.asList(1.9, 1.1), Arrays.asList(1.9, 1.9), Arrays.asList(1.1, 1.9))).intersects(r.polygon(Arrays.asList(1.1, 1.1), Arrays.asList(1.9, 1.1), Arrays.asList(1.9, 1.9), Arrays.asList(1.1, 1.9))) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, geo/intersection_inclusion.yaml, #18
                 //ExpectedOriginal: True
                 var expected = true;
                 
                 //Original: r.polygon([1,1], [2,1], [2,2], [1,2]).intersects(r.polygon([2,1.1], [3,1.1], [3,1.9], [2,1.9]))
                 var obtained = runOrCatch( r.polygon(Arrays.asList(1, 1), Arrays.asList(2, 1), Arrays.asList(2, 2), Arrays.asList(1, 2)).intersects(r.polygon(Arrays.asList(2, 1.1), Arrays.asList(3, 1.1), Arrays.asList(3, 1.9), Arrays.asList(2, 1.9))) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, geo/intersection_inclusion.yaml, #19
                 //ExpectedOriginal: False
                 var expected = false;
                 
                 //Original: r.polygon([1,1], [2,1], [2,2], [1,2]).intersects(r.polygon([2,2], [3,2], [3,3], [2,3]))
                 var obtained = runOrCatch( r.polygon(Arrays.asList(1, 1), Arrays.asList(2, 1), Arrays.asList(2, 2), Arrays.asList(1, 2)).intersects(r.polygon(Arrays.asList(2, 2), Arrays.asList(3, 2), Arrays.asList(3, 3), Arrays.asList(2, 3))) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, geo/intersection_inclusion.yaml, #20
                 //ExpectedOriginal: False
                 var expected = false;
                 
                 //Original: r.point(1,1).intersects(r.point(1.5,1.5))
                 var obtained = runOrCatch( r.point(1, 1).intersects(r.point(1.5, 1.5)) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, geo/intersection_inclusion.yaml, #21
                 //ExpectedOriginal: True
                 var expected = true;
                 
                 //Original: r.point(1,1).intersects(r.point(1,1))
                 var obtained = runOrCatch( r.point(1, 1).intersects(r.point(1, 1)) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, geo/intersection_inclusion.yaml, #22
                 //ExpectedOriginal: True
                 var expected = true;
                 
                 //Original: r.line([1,1], [2,1]).intersects(r.point(1,1))
                 var obtained = runOrCatch( r.line(Arrays.asList(1, 1), Arrays.asList(2, 1)).intersects(r.point(1, 1)) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, geo/intersection_inclusion.yaml, #23
                 //ExpectedOriginal: True
                 var expected = true;
                 
                 //Original: r.line([1,1], [1,2]).intersects(r.point(1,1.8))
                 var obtained = runOrCatch( r.line(Arrays.asList(1, 1), Arrays.asList(1, 2)).intersects(r.point(1, 1.8)) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, geo/intersection_inclusion.yaml, #24
                 //ExpectedOriginal: True
                 var expected = true;
                 
                 //Original: r.line([1,0], [2,0]).intersects(r.point(1.8,0))
                 var obtained = runOrCatch( r.line(Arrays.asList(1, 0), Arrays.asList(2, 0)).intersects(r.point(1.8, 0)) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, geo/intersection_inclusion.yaml, #25
                 //ExpectedOriginal: False
                 var expected = false;
                 
                 //Original: r.line([1,1], [2,1]).intersects(r.point(1.5,1.5))
                 var obtained = runOrCatch( r.line(Arrays.asList(1, 1), Arrays.asList(2, 1)).intersects(r.point(1.5, 1.5)) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, geo/intersection_inclusion.yaml, #26
                 //ExpectedOriginal: True
                 var expected = true;
                 
                 //Original: r.line([1,1], [2,1]).intersects(r.line([2,1], [3,1]))
                 var obtained = runOrCatch( r.line(Arrays.asList(1, 1), Arrays.asList(2, 1)).intersects(r.line(Arrays.asList(2, 1), Arrays.asList(3, 1))) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, geo/intersection_inclusion.yaml, #27
                 //ExpectedOriginal: 2
                 var expected = 2;
                 
                 //Original: r.expr([r.point(1, 0), r.point(3,0), r.point(2, 0)]).intersects(r.line([0,0], [2, 0])).count()
                 var obtained = runOrCatch( r.expr(Arrays.asList(r.point(1, 0), r.point(3, 0), r.point(2, 0))).intersects(r.line(Arrays.asList(0, 0), Arrays.asList(2, 0))).count() ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, geo/intersection_inclusion.yaml, #28
                 //ExpectedOriginal: True
                 var expected = true;
                 
                 //Original: r.polygon([1,1], [2,1], [2,2], [1,2]).includes(r.point(1.5,1.5))
                 var obtained = runOrCatch( r.polygon(Arrays.asList(1, 1), Arrays.asList(2, 1), Arrays.asList(2, 2), Arrays.asList(1, 2)).includes(r.point(1.5, 1.5)) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, geo/intersection_inclusion.yaml, #29
                 //ExpectedOriginal: False
                 var expected = false;
                 
                 //Original: r.polygon([1,1], [2,1], [2,2], [1,2]).includes(r.point(2.5,2.5))
                 var obtained = runOrCatch( r.polygon(Arrays.asList(1, 1), Arrays.asList(2, 1), Arrays.asList(2, 2), Arrays.asList(1, 2)).includes(r.point(2.5, 2.5)) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, geo/intersection_inclusion.yaml, #30
                 //ExpectedOriginal: False
                 var expected = false;
                 
                 //Original: r.polygon([1,1], [2,1], [2,2], [1,2]).polygon_sub(r.polygon([1.1,1.1], [1.9,1.1], [1.9,1.9], [1.1,1.9])).includes(r.point(1.5,1.5))
                 var obtained = runOrCatch( r.polygon(Arrays.asList(1, 1), Arrays.asList(2, 1), Arrays.asList(2, 2), Arrays.asList(1, 2)).polygonSub(r.polygon(Arrays.asList(1.1, 1.1), Arrays.asList(1.9, 1.1), Arrays.asList(1.9, 1.9), Arrays.asList(1.1, 1.9))).includes(r.point(1.5, 1.5)) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, geo/intersection_inclusion.yaml, #31
                 //ExpectedOriginal: True
                 var expected = true;
                 
                 //Original: r.polygon([1,1], [2,1], [2,2], [1,2]).polygon_sub(r.polygon([1.1,1.1], [1.9,1.1], [1.9,1.9], [1.1,1.9])).includes(r.point(1.05,1.05))
                 var obtained = runOrCatch( r.polygon(Arrays.asList(1, 1), Arrays.asList(2, 1), Arrays.asList(2, 2), Arrays.asList(1, 2)).polygonSub(r.polygon(Arrays.asList(1.1, 1.1), Arrays.asList(1.9, 1.1), Arrays.asList(1.9, 1.9), Arrays.asList(1.1, 1.9))).includes(r.point(1.05, 1.05)) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, geo/intersection_inclusion.yaml, #32
                 //ExpectedOriginal: True
                 var expected = true;
                 
                 //Original: r.polygon([1,1], [2,1], [2,2], [1,2]).includes(r.point(2,2))
                 var obtained = runOrCatch( r.polygon(Arrays.asList(1, 1), Arrays.asList(2, 1), Arrays.asList(2, 2), Arrays.asList(1, 2)).includes(r.point(2, 2)) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, geo/intersection_inclusion.yaml, #33
                 //ExpectedOriginal: True
                 var expected = true;
                 
                 //Original: r.polygon([1,1], [2,1], [2,2], [1,2]).includes(r.point(2,1.5))
                 var obtained = runOrCatch( r.polygon(Arrays.asList(1, 1), Arrays.asList(2, 1), Arrays.asList(2, 2), Arrays.asList(1, 2)).includes(r.point(2, 1.5)) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, geo/intersection_inclusion.yaml, #34
                 //ExpectedOriginal: True
                 var expected = true;
                 
                 //Original: r.polygon([1,1], [2,1], [2,2], [1,2]).includes(r.line([1.5,1.5], [2,2]))
                 var obtained = runOrCatch( r.polygon(Arrays.asList(1, 1), Arrays.asList(2, 1), Arrays.asList(2, 2), Arrays.asList(1, 2)).includes(r.line(Arrays.asList(1.5, 1.5), Arrays.asList(2, 2))) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, geo/intersection_inclusion.yaml, #35
                 //ExpectedOriginal: True
                 var expected = true;
                 
                 //Original: r.polygon([1,1], [2,1], [2,2], [1,2]).includes(r.line([1.5,1.5], [2,1.5]))
                 var obtained = runOrCatch( r.polygon(Arrays.asList(1, 1), Arrays.asList(2, 1), Arrays.asList(2, 2), Arrays.asList(1, 2)).includes(r.line(Arrays.asList(1.5, 1.5), Arrays.asList(2, 1.5))) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, geo/intersection_inclusion.yaml, #36
                 //ExpectedOriginal: True
                 var expected = true;
                 
                 //Original: r.polygon([1,1], [2,1], [2,2], [1,2]).polygon_sub(r.polygon([1.1,1.1], [1.9,1.1], [1.9,1.9], [1.1,1.9])).includes(r.point(1.1,1.1))
                 var obtained = runOrCatch( r.polygon(Arrays.asList(1, 1), Arrays.asList(2, 1), Arrays.asList(2, 2), Arrays.asList(1, 2)).polygonSub(r.polygon(Arrays.asList(1.1, 1.1), Arrays.asList(1.9, 1.1), Arrays.asList(1.9, 1.9), Arrays.asList(1.1, 1.9))).includes(r.point(1.1, 1.1)) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, geo/intersection_inclusion.yaml, #37
                 //ExpectedOriginal: True
                 var expected = true;
                 
                 //Original: r.polygon([1,1], [2,1], [2,2], [1,2]).polygon_sub(r.polygon([1.1,1.1], [1.9,1.1], [1.9,1.9], [1.1,1.9])).includes(r.point(1.5,1.1))
                 var obtained = runOrCatch( r.polygon(Arrays.asList(1, 1), Arrays.asList(2, 1), Arrays.asList(2, 2), Arrays.asList(1, 2)).polygonSub(r.polygon(Arrays.asList(1.1, 1.1), Arrays.asList(1.9, 1.1), Arrays.asList(1.9, 1.9), Arrays.asList(1.1, 1.9))).includes(r.point(1.5, 1.1)) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, geo/intersection_inclusion.yaml, #38
                 //ExpectedOriginal: False
                 var expected = false;
                 
                 //Original: r.polygon([1,1], [2,1], [2,2], [1,2]).includes(r.line([2,2], [3,3]))
                 var obtained = runOrCatch( r.polygon(Arrays.asList(1, 1), Arrays.asList(2, 1), Arrays.asList(2, 2), Arrays.asList(1, 2)).includes(r.line(Arrays.asList(2, 2), Arrays.asList(3, 3))) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, geo/intersection_inclusion.yaml, #39
                 //ExpectedOriginal: True
                 var expected = true;
                 
                 //Original: r.polygon([1,1], [2,1], [2,2], [1,2]).includes(r.line([2,1.5], [2,2]))
                 var obtained = runOrCatch( r.polygon(Arrays.asList(1, 1), Arrays.asList(2, 1), Arrays.asList(2, 2), Arrays.asList(1, 2)).includes(r.line(Arrays.asList(2, 1.5), Arrays.asList(2, 2))) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, geo/intersection_inclusion.yaml, #40
                 //ExpectedOriginal: True
                 var expected = true;
                 
                 //Original: r.polygon([1,1], [2,1], [2,2], [1,2]).includes(r.line([2,1], [2,2]))
                 var obtained = runOrCatch( r.polygon(Arrays.asList(1, 1), Arrays.asList(2, 1), Arrays.asList(2, 2), Arrays.asList(1, 2)).includes(r.line(Arrays.asList(2, 1), Arrays.asList(2, 2))) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, geo/intersection_inclusion.yaml, #41
                 //ExpectedOriginal: False
                 var expected = false;
                 
                 //Original: r.polygon([1,1], [2,1], [2,2], [1,2]).includes(r.line([1.5,1.5], [3,3]))
                 var obtained = runOrCatch( r.polygon(Arrays.asList(1, 1), Arrays.asList(2, 1), Arrays.asList(2, 2), Arrays.asList(1, 2)).includes(r.line(Arrays.asList(1.5, 1.5), Arrays.asList(3, 3))) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, geo/intersection_inclusion.yaml, #42
                 //ExpectedOriginal: True
                 var expected = true;
                 
                 //Original: r.polygon([1,1], [2,1], [2,2], [1,2]).includes(r.polygon([1,1], [2,1], [2,2], [1,2]))
                 var obtained = runOrCatch( r.polygon(Arrays.asList(1, 1), Arrays.asList(2, 1), Arrays.asList(2, 2), Arrays.asList(1, 2)).includes(r.polygon(Arrays.asList(1, 1), Arrays.asList(2, 1), Arrays.asList(2, 2), Arrays.asList(1, 2))) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, geo/intersection_inclusion.yaml, #43
                 //ExpectedOriginal: True
                 var expected = true;
                 
                 //Original: r.polygon([1,1], [2,1], [2,2], [1,2]).includes(r.polygon([1.2,1.2], [1.8,1.2], [1.8,1.8], [1.2,1.8]))
                 var obtained = runOrCatch( r.polygon(Arrays.asList(1, 1), Arrays.asList(2, 1), Arrays.asList(2, 2), Arrays.asList(1, 2)).includes(r.polygon(Arrays.asList(1.2, 1.2), Arrays.asList(1.8, 1.2), Arrays.asList(1.8, 1.8), Arrays.asList(1.2, 1.8))) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, geo/intersection_inclusion.yaml, #44
                 //ExpectedOriginal: True
                 var expected = true;
                 
                 //Original: r.polygon([1,1], [2,1], [2,2], [1,2]).includes(r.polygon([1.5,1.5], [2,1.5], [2,2], [1.5,2]))
                 var obtained = runOrCatch( r.polygon(Arrays.asList(1, 1), Arrays.asList(2, 1), Arrays.asList(2, 2), Arrays.asList(1, 2)).includes(r.polygon(Arrays.asList(1.5, 1.5), Arrays.asList(2, 1.5), Arrays.asList(2, 2), Arrays.asList(1.5, 2))) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, geo/intersection_inclusion.yaml, #45
                 //ExpectedOriginal: False
                 var expected = false;
                 
                 //Original: r.polygon([1,1], [2,1], [2,2], [1,2]).includes(r.polygon([1.5,1.5], [2.5,1.5], [2.5,2.5], [1.5,2.5]))
                 var obtained = runOrCatch( r.polygon(Arrays.asList(1, 1), Arrays.asList(2, 1), Arrays.asList(2, 2), Arrays.asList(1, 2)).includes(r.polygon(Arrays.asList(1.5, 1.5), Arrays.asList(2.5, 1.5), Arrays.asList(2.5, 2.5), Arrays.asList(1.5, 2.5))) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, geo/intersection_inclusion.yaml, #46
                 //ExpectedOriginal: False
                 var expected = false;
                 
                 //Original: r.polygon([1,1], [2,1], [2,2], [1,2]).polygon_sub(r.polygon([1.1,1.1], [1.9,1.1], [1.9,1.9], [1.1,1.9])).includes(r.polygon([1.2,1.2], [1.8,1.2], [1.8,1.8], [1.2,1.8]))
                 var obtained = runOrCatch( r.polygon(Arrays.asList(1, 1), Arrays.asList(2, 1), Arrays.asList(2, 2), Arrays.asList(1, 2)).polygonSub(r.polygon(Arrays.asList(1.1, 1.1), Arrays.asList(1.9, 1.1), Arrays.asList(1.9, 1.9), Arrays.asList(1.1, 1.9))).includes(r.polygon(Arrays.asList(1.2, 1.2), Arrays.asList(1.8, 1.2), Arrays.asList(1.8, 1.8), Arrays.asList(1.2, 1.8))) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, geo/intersection_inclusion.yaml, #47
                 //ExpectedOriginal: False
                 var expected = false;
                 
                 //Original: r.polygon([1,1], [2,1], [2,2], [1,2]).polygon_sub(r.polygon([1.1,1.1], [1.9,1.1], [1.9,1.9], [1.1,1.9])).includes(r.polygon([1.1,1.1], [2,1.1], [2,2], [1.1,2]))
                 var obtained = runOrCatch( r.polygon(Arrays.asList(1, 1), Arrays.asList(2, 1), Arrays.asList(2, 2), Arrays.asList(1, 2)).polygonSub(r.polygon(Arrays.asList(1.1, 1.1), Arrays.asList(1.9, 1.1), Arrays.asList(1.9, 1.9), Arrays.asList(1.1, 1.9))).includes(r.polygon(Arrays.asList(1.1, 1.1), Arrays.asList(2, 1.1), Arrays.asList(2, 2), Arrays.asList(1.1, 2))) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, geo/intersection_inclusion.yaml, #48
                 //ExpectedOriginal: False
                 var expected = false;
                 
                 //Original: r.polygon([1,1], [2,1], [2,2], [1,2]).includes(r.polygon([2,1.1], [3,1.1], [3,1.9], [2,1.9]))
                 var obtained = runOrCatch( r.polygon(Arrays.asList(1, 1), Arrays.asList(2, 1), Arrays.asList(2, 2), Arrays.asList(1, 2)).includes(r.polygon(Arrays.asList(2, 1.1), Arrays.asList(3, 1.1), Arrays.asList(3, 1.9), Arrays.asList(2, 1.9))) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, geo/intersection_inclusion.yaml, #49
                 //ExpectedOriginal: False
                 var expected = false;
                 
                 //Original: r.polygon([1,1], [2,1], [2,2], [1,2]).includes(r.polygon([2,2], [3,2], [3,3], [2,3]))
                 var obtained = runOrCatch( r.polygon(Arrays.asList(1, 1), Arrays.asList(2, 1), Arrays.asList(2, 2), Arrays.asList(1, 2)).includes(r.polygon(Arrays.asList(2, 2), Arrays.asList(3, 2), Arrays.asList(3, 3), Arrays.asList(2, 3))) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, geo/intersection_inclusion.yaml, #50
                 //ExpectedOriginal: 1
                 var expected = 1;
                 
                 //Original: r.expr([r.polygon([0,0], [1,1], [1,0]), r.polygon([0,1], [1,2], [1,1])]).includes(r.point(0,0)).count()
                 var obtained = runOrCatch( r.expr(Arrays.asList(r.polygon(Arrays.asList(0, 0), Arrays.asList(1, 1), Arrays.asList(1, 0)), r.polygon(Arrays.asList(0, 1), Arrays.asList(1, 2), Arrays.asList(1, 1)))).includes(r.point(0, 0)).count() ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, geo/intersection_inclusion.yaml, #51
                 //ExpectedOriginal: err('ReqlQueryLogicError', 'Expected geometry of type `Polygon` but found `Point`.')
                 var expected = err("ReqlQueryLogicError", "Expected geometry of type `Polygon` but found `Point`.");
                 
                 //Original: r.point(0,0).includes(r.point(0,0))
                 var obtained = runOrCatch( r.point(0, 0).includes(r.point(0, 0)) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, geo/intersection_inclusion.yaml, #52
                 //ExpectedOriginal: err('ReqlQueryLogicError', 'Expected geometry of type `Polygon` but found `LineString`.')
                 var expected = err("ReqlQueryLogicError", "Expected geometry of type `Polygon` but found `LineString`.");
                 
                 //Original: r.line([0,0], [0,1]).includes(r.point(0,0))
                 var obtained = runOrCatch( r.line(Arrays.asList(0, 0), Arrays.asList(0, 1)).includes(r.point(0, 0)) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             

        }
    }
}