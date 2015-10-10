




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
    public class Regression46 : GeneratedTest {



        [Test]
        public void YamlTest(){

             TestCounter++;
             
             {
                 //JavaQuery, regression/46.yaml, #1
                 /* ExpectedOriginal: partial({'tables_created':1}) */
                 var expected_ = partial(r.hashMap("tables_created", 1));
                 
                 /* Original: r.table_create('46') */
                 var obtained = runOrCatch( r.tableCreate("46") ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, regression/46.yaml, #2
                 /* ExpectedOriginal: (['46']) */
                 var expected_ = r.array("46");
                 
                 /* Original: r.table_list() */
                 var obtained = runOrCatch( r.tableList() ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, regression/46.yaml, #3
                 /* ExpectedOriginal: partial({'tables_dropped':1}) */
                 var expected_ = partial(r.hashMap("tables_dropped", 1));
                 
                 /* Original: r.table_drop('46') */
                 var obtained = runOrCatch( r.tableDrop("46") ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             

        }
    }
}
