using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Serialization;
using System.Text;

namespace game.gameclasses {

    // ==========================================================
    // class ThingList
    // ==========================================================
    [Serializable]
    public class ThingList : List<Thing> {

        public string Describe() {
            string s = "";
            if (this.Count == 0) {
                s = "nothing.\r\n";
            }
            else {
                foreach (Thing t in this) {
                    s = s + t.Describe() + "; ";
                }
            }

            return s;
        }

        public Thing ThisOb(string aName) {
            Thing athing = null;
            string thingName = "";
            string aNameLowCase = aName.Trim().ToLower();
            foreach (Thing t in this) {
                thingName = t.Name.Trim().ToLower();
                if (thingName.Equals(aNameLowCase)) {
                    athing = t;
                }
            }
            return athing;
        }

    } // ThingList

    // ==========================================================
    // class RoomList
    // ==========================================================
    [Serializable]
    public class RoomList : Dictionary<Rm, Room> {

        protected RoomList(SerializationInfo info, StreamingContext context)
        : base(info, context) {
            // constructor needed for serialization
        }

        public RoomList() { }

        public Room RoomAt(Rm Index) {
            return this[Index];
        }

        public string Describe() {
            string s = "";
            if (this.Count == 0) {
                s = "Nothing in RoomList.";
            }
            else {
                foreach (KeyValuePair<Rm, Room> kv in this) {
                    s = s + kv.Value.Describe() + "\r\n";
                }
                /*
                 // This works too! Below, I use the keyword var which the compiler
                 // initializes to the appropriate type (here the key-value pair: Rm, Room)
                 // Some programmers like to use var as it saves typing effort. Personally
                 // I prefer the absolute clarity of stating the type explicity like this:
                 //       KeyValuePair<Rm,Room> kv 

                foreach (var kv in this) {
                    s = s + kv.Value.Describe() + "\r\n";
                }
                */
            }
            return s;
        }


    } // RoomList

}