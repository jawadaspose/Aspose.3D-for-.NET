﻿using System;
using System.IO;
using System.Collections;
using Aspose.ThreeD;
using Aspose.ThreeD.Animation;
using Aspose.ThreeD.Entities;
using Aspose.ThreeD.Formats;

namespace CSharp._Working_with_Objects
{
    class ConvertBoxPrimitivetoMesh
    {
        public static void Run()
        {
            // Initialize scene object
            Scene scene = new Scene();

            // Initialize Node class object
            Node cubeNode = new Node("box");

            //ExStart:ConvertBoxPrimitivetoMesh
            // initialize object by Box class
            IMeshConvertible convertible = new Box();
            // convert a Box to Mesh
            Mesh mesh = convertible.ToMesh();
            //ExEnd:ConvertBoxPrimitivetoMesh

            // Point node to the Mesh geometry
            cubeNode.Entity = mesh;

            // Add Node to a scene
            scene.RootNode.ChildNodes.Add(cubeNode);

            // The path to the documents directory.
            string MyDir = RunExamples.GetDataDir() + RunExamples.GetOutputFilePath("BoxToMeshScene.fbx");

            // Save 3D scene in the supported file formats
            scene.Save(MyDir, FileFormat.FBX7400ASCII);

            Console.WriteLine("\n Converted the primitive Box to a mesh successfully.\nFile saved at " + MyDir);
        }
    }
}
