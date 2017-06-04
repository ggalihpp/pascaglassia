using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefenceOfMakers
{
    class Invader
    {
        private readonly Path _path;
        private int _pathStep = 0;
        protected virtual int stepSize { get; } = 1;
        public virtual int Health { get; protected set; } = 5;

        public MapLocation Location
        {
            get
            {
                return _path.getLocationAt(_pathStep);
            }
        }


        public Invader(Path path)
        {
            _path = path;
        }

        public virtual void Move()
        {
            _pathStep += stepSize;
        }

        public virtual void decreaseHealth(int factor)
        {
            Health -= factor;
        }

        public bool HasScored
        {
            get
            {
                return _pathStep >= _path.Length;
            }
        }
        
        public bool IsNeutralized
        {
            get
            {
                return Health <= 0;
            }
        }

        public bool IsActive
        {
            get
            {
                    return !(IsNeutralized || HasScored);
                }
            }
        }
    }
