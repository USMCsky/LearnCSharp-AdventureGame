using System;
using System.Collections.Generic;

namespace game.gameclasses {
    // ==========================================================
    // class RoomList
    // ==========================================================
    [Serializable]
    public class RoomList : List<Room> {

        public Room RoomAt(int Index) {
            return this[Index];
        }

        public string Describe() {
            string s = "";
            if (this.Count == 0) {
                s = "Nothing in RoomList.";
            } else {
                foreach (Room r in this) {
                    s = s + r.Describe() + "\r\n";
                }
            }
            return s;
        }


    } // RoomList

}