﻿Imports System.IO
Imports VisualBasic.Geometry_Hierarchy
Imports VisualBasic.Animation
Imports VisualBasic.AssetInformation
Imports VisualBasic.Loading_Saving
Imports VisualBasic._3DScene
Imports VisualBasic._3DModeling
Imports VisualBasic.Working_with_Objects

Module RunExamples
    Sub Main()
        Console.WriteLine("Open RunExamples.vb. In Main() method, Un-comment the example that you want to run")
        Console.WriteLine("=====================================================")

        ' Un-comment the one you want to try out

        '' =====================================================
        '' =====================================================
        '' Loading and Saving
        '' =====================================================
        '' =====================================================

        'Save3DScene.Run()
        'ReadExistingScene.Run()
        'CreateEmpty3DDocument.Run()

        '' =====================================================
        '' =====================================================
        '' Animation
        '' =====================================================
        '' =====================================================

        'PropertyToDocument.Run()
        'SetupTargetAndCamera.Run()

        '' =====================================================
        '' =====================================================
        '' 3DScene
        '' =====================================================
        '' =====================================================

        'FlipCoordinateSystem.Run()

        '' =====================================================
        '' =====================================================
        '' Asset Information
        '' =====================================================
        '' =====================================================

        'InformationToScene.Run()

        '' =====================================================
        '' =====================================================
        '' Geometry and Hierarchy
        '' =====================================================

        'CubeScene.Run()
        'MaterialToCube.Run()
        'TransformationToNodeByQuaternion.Run()
        'TransformationToNodeByEulerAngles.Run()
        'TransformationToNodeByTransformationMatrix.Run()
        'NodeHierarchy.Run()
        'MeshGeometryData.Run()
        'SetupNormalsOnCube.Run()
        'SetupUVOnCube.Run()
        'TriangulateMesh.Run()

        '' =====================================================
        '' =====================================================
        '' 3D Modeling
        '' =====================================================
        '' =====================================================

        'Primitive3DModels.Run()

        '' =====================================================
        '' =====================================================
        '' Working with Objects
        '' =====================================================
        '' =====================================================

        'SplitMeshbyMaterial.Run()
        'ConvertSpherePrimitivetoMesh.Run()
        'ConvertBoxPrimitivetoMesh.Run()
        'ConvertPlanePrimitivetoMesh.Run()
        'ConvertCylinderPrimitivetoMesh.Run()
        'ConvertTorusPrimitivetoMesh.Run()
        'ConvertSphereMeshtoTriangleMeshCustomMemoryLayout.Run()
        ConvertBoxMeshtoTriangleMeshCustomMemoryLayout.Run()

        ' Stop before exiting
        Console.WriteLine(vbLf & vbLf & "Program Finished. Press any key to exit....")
        Console.ReadKey()
    End Sub

    Public Function GetDataDir() As String
        Dim parent = Directory.GetParent(Directory.GetCurrentDirectory()).Parent
        Dim startDirectory As String = Nothing
        If parent IsNot Nothing Then
            Dim directoryInfo = parent.Parent
            If directoryInfo IsNot Nothing Then
                startDirectory = directoryInfo.FullName
            End If
        Else
            startDirectory = parent.FullName
        End If
        Return Path.Combine(startDirectory, "Data\")
    End Function
    Public Function GetOutputFilePath(inputFilePath As [String]) As String
        Dim extension As String = Path.GetExtension(inputFilePath)
        Dim filename As String = Path.GetFileNameWithoutExtension(inputFilePath)
        Return Convert.ToString(filename & Convert.ToString("_out_")) & extension
    End Function
End Module
