using System;
using System.Collections.Generic;
using System.Text;

namespace game.gameclasses {
    // ==========================================================
    // class Room
    // ==========================================================
    [Serializable]
    public class Room : ThingHolder {
        private Rm _n, _s, _w, _e;
        public Room(string aName, string aDescription,
            Rm aN, Rm aS, Rm aW, Rm aE, ThingList tl)
            : base(aName, aDescription, tl) {
            _n = aN;
            _s = aS;
            _w = aW;
            _e = aE;
        }

        public Rm N {
            get => _n;
            set => _n = value;
        }

        public Rm S {
            get => _s;
            set => _s = value;
        }

        public Rm W {
            get => _w;
            set => _w = value;
        }

        public Rm E {
            get => _e;
            set => _e = value;
        }

        public void SetDirs(Rm aN, Rm aS, Rm aW, Rm aE) {
            _n = aN;
            _s = aS;
            _w = aW;
            _e = aE;
        }

        public void GetDirs(out Rm aN, out Rm aS,
                             out Rm aW, out Rm aE) {
            aN = _n;
            aS = _s;
            aW = _w;
            aE = _e;
        }

        public override string Describe() {
            return String.Format("Name: {0}, Description {1}.", Name, Description)
                    + "\r\nThings here: " + this.Things.Describe();
        }


    } // Room
}
