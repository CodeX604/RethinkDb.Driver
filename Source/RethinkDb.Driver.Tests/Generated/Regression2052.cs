




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
    public class Regression2052 : GeneratedTest {



        [Test]
        public void YamlTest(){

             TestCounter++;
             
             {
                 //JavaQuery, regression/2052.yaml, #1
                 /* ExpectedOriginal: 1 */
                 var expected_ = 1;
                 
                 /* Original: r.expr(1) */
                 var obtained = runOrCatch( r.expr(1) ,
                                            new OptArgs()
                     .with("array_limit", 16)
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, regression/2052.yaml, #2
                 /* ExpectedOriginal: err("ReqlCompileError", "Unrecognized global optional argument `obviously_bogus`.", []) */
                 var expected_ = err("ReqlCompileError", "Unrecognized global optional argument `obviously_bogus`.", r.array());
                 
                 /* Original: r.expr(1) */
                 var obtained = runOrCatch( r.expr(1) ,
                                            new OptArgs()
                     .with("obviously_bogus", 16)
                    );
                 assertEquals(expected_, obtained);
             }
             

        }
    }
}
