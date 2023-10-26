using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
       
    }

    interface IMovable
    {
        void Move();
        void ShowMoveSpeed();
    }

    interface IBurnable
    {
        void Burn();
    }

    class Vehicle
    {

    }

    class Car : Vehicle, IMovable, IBurnable 
    {
        public void Move() 
        {
        
        }

        public void ShowMoveSpeed()
        {

        }

        public void Burn()
        {

        }
    }

    class Human: IMovable
    {
        public void Move()
        {

        }

        public void ShowMoveSpeed()
        {

        }
    }
}