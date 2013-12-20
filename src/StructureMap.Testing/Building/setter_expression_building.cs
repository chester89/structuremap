﻿using System;
using NUnit.Framework;
using StructureMap.Building;

namespace StructureMap.Testing.Building
{
    [TestFixture]
    public class setter_expression_building
    {
        [Test]
        public void simple_creation_of_properties_with_only_constants()
        {
            var step = new ConcreteBuild<SetterTarget>();
            step.Set(x => x.Color, "Red");
            step.Set(x => x.Direction, "North");

            var builder = (Func<IContext, SetterTarget>) step.ToDelegate();
            SetterTarget target = builder(new FakeContext());

            target.Color.ShouldEqual("Red");
            target.Direction.ShouldEqual("North");
        }

        [Test]
        public void simple_creation_of_fields_with_only_constants()
        {
            var step = new ConcreteBuild<FieldTarget>();
            step.Set(x => x.Color, "Red");
            step.Set(x => x.Direction, "North");

            var builder = (Func<IContext, FieldTarget>)step.ToDelegate();
            FieldTarget target = builder(new FakeContext());

            target.Color.ShouldEqual("Red");
            target.Direction.ShouldEqual("North");
        }
    }

    public class SetterTarget
    {
        public string Color { get; set; }
        public string Direction { get; set; }
    }

    public class FieldTarget
    {
        public string Color;
        public string Direction;
    }
}