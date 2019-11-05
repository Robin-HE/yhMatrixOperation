using System;
using System.Collections.Generic;

using Grasshopper.Kernel;
using Rhino.Geometry;

using Accord;
using Accord.Math;


namespace yhComp
{
    public class RandomMatrix : GH_Component
    {
        /// <summary>
        /// Initializes a new instance of the RandomMatrix class.
        /// </summary>
        public RandomMatrix()
          : base("RandomMatrix",
                "RandomMatrix",
              "RandomMatrix",
              "yhGridShell",
              "Matrix")
        {
        }

        /// <summary>
        /// Registers all the input parameters for this component.
        /// </summary>
        protected override void RegisterInputParams(GH_Component.GH_InputParamManager pManager)
        {
        }

        /// <summary>
        /// Registers all the output parameters for this component.
        /// </summary>
        protected override void RegisterOutputParams(GH_Component.GH_OutputParamManager pManager)
        {
            pManager.AddMatrixParameter("RandomMatrix", "RandomMatrix", "RandomMatrix", GH_ParamAccess.list);
        }

        /// <summary>
        /// This is the method that actually does the work.
        /// </summary>
        /// <param name="DA">The DA object is used to retrieve from inputs and store in outputs.</param>
        protected override void SolveInstance(IGH_DataAccess DA)
        {
            int numRow = 5;
            int numCol = 5;
            double[,] A = Accord.Math.Matrix.Random(numRow, numCol, 10.0, 100.0);
            DA.SetDataList(0, A);
        }

        /// <summary>
        /// Provides an Icon for the component.
        /// </summary>
        protected override System.Drawing.Bitmap Icon
        {
            get
            {
                //You can add image files to your project resources and access them like this:
                // return Resources.IconForThisComponent;
                return null;
            }
        }

        /// <summary>
        /// Gets the unique ID for this component. Do not change this ID after release.
        /// </summary>
        public override Guid ComponentGuid
        {
            get { return new Guid("575775d5-0874-42cd-a68d-a826bd7c420c"); }
        }
    }
}