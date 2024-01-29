using System;
using InheritanceExercise2.Entities.Enums;

namespace InheritanceExercise2.Entities
{
     abstract class Shape
    {
        public Color Color { get; set; }

        public Shape(Color color) 
        { 
            Color = color;
        }

        public abstract double Area();
    }
}
