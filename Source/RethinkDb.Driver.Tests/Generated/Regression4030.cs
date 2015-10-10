




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
    public class Regression4030 : GeneratedTest {

            public static Table tbl = r.db(DbName).table("tbl");


        [Test]
        public void YamlTest(){

             
             //JavaDef, regression/4030.yaml, #Templates.YamlTest+DefTest.
             //Original: data = [{'id':1}, {'id':2}, {'id':3}, {'id':4}, {'id':5}, {'id':6}]
             
IList data = (IList) (r.array(r.hashMap("id", 1), r.hashMap("id", 2), r.hashMap("id", 3), r.hashMap("id", 4), r.hashMap("id", 5), r.hashMap("id", 6)));             
             
             //JavaDef, regression/4030.yaml, #Templates.YamlTest+DefTest.
             //Original: changes = [{'id':7}, {'id':8}, {'id':9}, {'id':10}]
             
IList changes = (IList) (r.array(r.hashMap("id", 7), r.hashMap("id", 8), r.hashMap("id", 9), r.hashMap("id", 10)));             
             TestCounter++;
             
             {
                 //JavaQuery, regression/4030.yaml, #3
                 /* ExpectedOriginal: partial({'errors':0, 'inserted':6}) */
                 var expected_ = partial(r.hashMap("errors", 0).with("inserted", 6));
                 
                 /* Original: tbl.insert(data) */
                 var obtained = runOrCatch( tbl.insert(data) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, regression/4030.yaml, #4
                 /* ExpectedOriginal: (6) */
                 var expected_ = 6;
                 
                 /* Original: tbl.count() */
                 var obtained = runOrCatch( tbl.count() ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, regression/4030.yaml, #5
                 /* ExpectedOriginal: bag(data * 2) */
                 var expected_ = bag((IList)Enumerable.Concat(data.OfType<object>().ToList(), data.OfType<object>().ToList()).ToList());
                 
                 /* Original: tbl.union(tbl) */
                 var obtained = runOrCatch( tbl.union(tbl) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, regression/4030.yaml, #6
                 /* ExpectedOriginal: bag(data * 2) */
                 var expected_ = bag((IList)Enumerable.Concat(data.OfType<object>().ToList(), data.OfType<object>().ToList()).ToList());
                 
                 /* Original: r.union(tbl, tbl) */
                 var obtained = runOrCatch( r.union(tbl, tbl) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             

        }
    }
}
