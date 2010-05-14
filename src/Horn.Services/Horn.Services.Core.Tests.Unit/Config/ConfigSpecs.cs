﻿using System;
using Horn.Services.Core.Config;
using Horn.Spec.Framework;
using NUnit.Framework;

namespace Horn.Services.Core.Tests.Unit.Config
{
    public class When_the_config_is_read : ContextSpecification
    {
        protected override void establish_context()
        {
        }

        protected override void because()
        {
        }

        [Test]
        public void Then_the_drop_directory_is_retrieved()
        {
            Assert.That(HornServiceConfig.Settings.DropDirectory.Length, Is.GreaterThan(0));
        }


        [Test]
        public void Then_the_build_frequency_is_retrieved()
        {
            Assert.That(HornServiceConfig.Settings.BuildFrequency, Is.GreaterThan(0));
        }

        [Test]
        public void Then_the_horn_root_directory_is_retured()
        {
            Assert.That(HornServiceConfig.Settings.HornRootDirectory.Length, Is.GreaterThan(0));
        }

        [Test]
        public void Then_the_xml_location_is_retured()
        {
            Assert.That(HornServiceConfig.Settings.XmlLocation.Length, Is.GreaterThan(0));
        }
    }
}
