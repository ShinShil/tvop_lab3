using System;

namespace lab3_triangle
{
    class TriangleModel
    {
        public Int64 A { get; set; }
        public Int64 B { get; set; }
        public Int64 C { get; set; }

        public bool Valid {
            get
            {
                return A + B > C && A + C > B && C + B > A;
            }
        }
        
        public bool isEqualeteral {
            get {
                return A == B && A == C && B == C;
            }
        }

        public bool isIsocseless {
            get
            {
                return !isEqualeteral && (A == B || A == C || B == C);
            }
        }

        public bool isVersatile
        {
            get
            {
                return !isEqualeteral && !isIsocseless;
            }
        }
    }
}
