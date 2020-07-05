﻿using System;
using ProtoBuf.Grpc.Reflection;
using Shared.Contracts;

namespace ConfTool.Tools
{
    class Program
    {
        static void Main(string[] args)
        {
            var generator = new SchemaGenerator(); // optional controls on here, we can add more add needed
            var schema = generator.GetSchema<IConferencesService>(); // there is also a non-generic overload that takes Type

            Console.WriteLine("SCHEMA: " + schema);
        }
    }
}
