﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using SummarizeThis.Core.Stem;

namespace SummarizeThis.Tests.Unit
{
    [TestFixture]
    class PorterStemmerTests
    {
        [Test]
        public void LessThan2Chars()
        {
            var at = "at";
            var stemmer = new PorterStemmer();

            Assert.AreEqual(at, stemmer.Stem(at));
        }

        [Test]
        public void CanStem()
        {
            var shopping = "shopping";
            var shop = "shop";
            var stemmer = new PorterStemmer();

            Assert.AreEqual(shop, stemmer.Stem(shopping));
        }
    }
}
