﻿/* 
 * Copyright (c) 2014, Furore (info@furore.com) and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/ewoutkramer/fhir-net-api/master/LICENSE
 */

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hl7.Fhir.Support;
using Hl7.Fhir.Rest;

namespace Hl7.Fhir.Test
{
    [TestClass]
#if PORTABLE45
	public class PortableTestRestUrl
#else
    public class TestRestUrl
#endif
    {
        [TestMethod, Ignore]
        public void Query()
        {
            //RestUrl endpoint = new RestUrl("http://localhost/fhir");
            //RestUrl resturi;

            //resturi = endpoint.Search("organization").AddParam("family", "Johnson").AddParam("given", "William");
            //Assert.AreEqual("http://localhost/fhir/organization/_search?family=Johnson&given=William", resturi.AsString);

            //var rl2 = new RestUrl(resturi.Uri);

            //rl2.AddParam("given", "Piet");
            //Assert.AreEqual("http://localhost/fhir/organization/_search?family=Johnson&given=William&given=Piet", rl2.AsString);
        }


        [TestMethod]
        public void TryNavigation()
        {
            var old = new RestUrl("http://www.hl7.org/svc/Organization/");
            var rl = old.NavigateTo("../Patient/1/_history");

            Assert.AreEqual("http://www.hl7.org/svc/Patient/1/_history", rl.ToString());

            old = new RestUrl("http://hl7.org/fhir/Patient/1");
            rl = old.NavigateTo("2");
            Assert.AreEqual("http://hl7.org/fhir/Patient/2", rl.ToString());

            rl = old.NavigateTo("../Observation/3");
            Assert.AreEqual("http://hl7.org/fhir/Observation/3", rl.ToString());
        }


        [TestMethod]
        public void TestIsEndpointFor()
        {
            var u = new RestUrl("http://www.hl7.org/svc");

            Assert.IsTrue(u.IsEndpointFor("http://www.hl7.org/svc/Organization"));
            Assert.IsTrue(u.IsEndpointFor("http://www.hl7.org/svc/Organization/search?name=eve"));
            Assert.IsFalse(u.IsEndpointFor("http://www.hl7.org/svx/Organization"));
            Assert.IsFalse(u.IsEndpointFor("http://www.hl7.org/"));

            u = new RestUrl("http://www.hl7.org/svc/");

            Assert.IsTrue(u.IsEndpointFor("http://www.hl7.org/svc/Organization"));
            Assert.IsTrue(u.IsEndpointFor("http://www.hl7.org/svc/Organization/search?name=eve"));
            Assert.IsFalse(u.IsEndpointFor("http://www.hl7.org/svx/Organization"));
            Assert.IsFalse(u.IsEndpointFor("http://www.hl7.org/"));
        }

        //[TestMethod]
        //public void ParamManipulation()
        //{
        //    var rl = new ResourceLocation("patient/search?name=Kramer&name=Moreau&oauth=XXX");

        //    rl.SetParam("newParamA", "1");
        //    rl.SetParam("newParamB", "2");
        //    Assert.IsTrue(rl.ToString().EndsWith("oauth=XXX&newParamA=1&newParamB=2"));

        //    rl.SetParam("newParamA", "3");
        //    rl.ClearParam("newParamB");
        //    Assert.IsTrue(rl.ToString().EndsWith("oauth=XXX&newParamA=3"));

        //    rl.AddParam("newParamA", "4");
        //    Assert.IsTrue(rl.ToString().EndsWith("oauth=XXX&newParamA=3&newParamA=4"));

        //    rl.AddParam("newParamB", "5");
        //    Assert.IsTrue(rl.ToString().EndsWith("oauth=XXX&newParamA=3&newParamA=4&newParamB=5"));

        //    Assert.AreEqual("patient/search?name=Kramer&name=Moreau&oauth=XXX&newParamA=3&newParamA=4&newParamB=5",
        //            rl.OperationPath.ToString());

        //    rl = new ResourceLocation("patient/search");
        //    rl.SetParam("firstParam", "1");
        //    rl.SetParam("sndParam", "2");
        //    rl.ClearParam("sndParam");
        //    Assert.AreEqual("patient/search?firstParam=1", rl.OperationPath.ToString());

        //    rl.ClearParam("firstParam");
        //    Assert.AreEqual("patient/search", rl.OperationPath.ToString());

        //    rl.SetParam("firstParam", "1");
        //    rl.SetParam("sndParam", "2");
        //    rl.ClearParams();
        //    Assert.AreEqual("patient/search", rl.OperationPath.ToString());
        //}
    }
}
