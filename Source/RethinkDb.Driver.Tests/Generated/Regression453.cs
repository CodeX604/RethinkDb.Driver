




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
    public class Regression453 : GeneratedTest {

            public static Table tbl = r.db(DbName).table("tbl");


        [Test]
        public void YamlTest(){

             TestCounter++;
             
             {
                 //JavaQuery, regression/453.yaml, #1
                 /* ExpectedOriginal: None */
                 var expected_ = null as object;
                 
                 /* Original: tbl.insert([{'a':1},{'a':2}]) */
                 var obtained = runOrCatch( tbl.insert(r.array(r.hashMap("a", 1), r.hashMap("a", 2))) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, regression/453.yaml, #2
                 /* ExpectedOriginal: err("ReqlQueryLogicError", 'Expected type DATUM but found TABLE:', [0]) */
                 var expected_ = err("ReqlQueryLogicError", "Expected type DATUM but found TABLE:", r.array(0));
                 
                 /* Original: tbl.map(lambda x: tbl) */
                 var obtained = runOrCatch( tbl.map(x => tbl) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, regression/453.yaml, #3
                 /* ExpectedOriginal: 2 */
                 var expected_ = 2;
                 
                 /* Original: tbl.map(lambda x: tbl.coerce_to('array')).count() */
                 var obtained = runOrCatch( tbl.map(x => tbl.coerceTo("array")).count() ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             

        }
    }
}
