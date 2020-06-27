using System;
using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace CUBE_RENDERING
{
    public class Game
    {
        GameWindow window;
        Cube cube;

        public Game(GameWindow window) {
            this.window = window;

            cube = new Cube();
            updater();
        }

        void updater() {
            GL.Translate(0, 0, -55); // we will translate the camera to view the whole cube
            // Calls a function individually when the window updates

            window.RenderFrame += render;
            window.Resize += resize;
            window.Load += loaded;

            window.Run(1/60);
        }

        void render(object sender, EventArgs e) {
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            GL.Rotate(1, 10, 10, 0);
            cube.render(); // Rendering the cube

            window.SwapBuffers();
        }

        void resize(object sender, EventArgs e) {

            // Settings on how to render the scene
            GL.Viewport(0, 0, window.Width, window.Height);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();

            Matrix4 perspectiveMatrix =
                Matrix4.CreatePerspectiveFieldOfView(1, window.Width / window.Height, 1.0f, 1000.0f);
            GL.LoadMatrix(ref perspectiveMatrix);
            GL.MatrixMode(MatrixMode.Modelview);
            GL.End();
        }

        void loaded(object sender, EventArgs e) {
            GL.ClearColor(0, 0, 0, 0);
            GL.Enable(EnableCap.DepthTest);
        }
    }
}
