using System;

namespace Abstraction
{
    /// <summary>
    /// Interface for classes capable of creating Figures
    /// </summary>
    internal interface IFigure
    {
        /// <summary>
        /// Calculate Figure perimeter
        /// </summary>
        /// <returns>value</returns>
        double CalculatePerimeter();

        /// <summary>
        /// Calculate Figure Surface
        /// </summary>
        /// <returns>value</returns>
        double CalculateSurface();
    }
}