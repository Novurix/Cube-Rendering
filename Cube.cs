using System;
using OpenTK.Graphics.OpenGL;

namespace CUBE_RENDERING
{
    public class Cube
    {
        // Cubes have six sides, and each side has four vertices.
        // When rendering a cube, we will have to render each individual vertex.
        // There will be a total of 24 vertices to place and render.
        // 24 = sides (6) multiplied by the vertices/points per side (4)

        public void render()
        {
            // We will define a 3D position (Vector3) to place each vertex.
            GL.Begin(BeginMode.Quads);

            GL.Color3(1.0, 1.0, 1.0); // make sure that the color values end with .0 (if you are using whole numbers)

            // Front
            GL.Vertex3(-10, 10, 10);
            GL.Vertex3(10, 10, 10);
            GL.Vertex3(10, -10, 10);
            GL.Vertex3(-10, -10, 10);

            GL.Color3(1.0, 0.0, 0.0); 

            // Back
            GL.Vertex3(-10, 10, -10);
            GL.Vertex3(10, 10, -10);
            GL.Vertex3(10, -10, -10);
            GL.Vertex3(-10, -10, -10);

            GL.Color3(0.0, 1.0, 0.0); 

            // Left
            GL.Vertex3(-10, 10, -10);
            GL.Vertex3(-10, 10, 10);
            GL.Vertex3(-10, -10, 10);
            GL.Vertex3(-10, -10, -10);

            GL.Color3(0.0, 0.0, 1.0); 

            // Right
            GL.Vertex3(10, 10, -10);
            GL.Vertex3(10, 10, 10);
            GL.Vertex3(10, -10, 10);
            GL.Vertex3(10, -10, -10);

            GL.Color3(1.0, 1.0, 0.0);

            // Top
            GL.Vertex3(-10, 10, -10);
            GL.Vertex3(-10, 10, 10);
            GL.Vertex3(10, 10, 10);
            GL.Vertex3(10, 10, -10);

            GL.Color3(1.0, 0.5, 0.0);

            // Bottom
            GL.Vertex3(-10, -10, -10);
            GL.Vertex3(-10, -10, 10);
            GL.Vertex3(10, -10, 10);
            GL.Vertex3(10, -10, -10);

            GL.End();
        }
    }
}
