using System;
using game.gameclasses;

namespace game {
    /// <summary>
    /// The Adventure class contains the 'world' of the game:
    /// the player and any other actors, plus the map.
    /// </summary>
    /// 
    [Serializable]
    public class Adventure {
        private Actor _player;
        private RoomList _map = new RoomList();
    //    private const int NOEXIT = -1;

        public Adventure() {
            // CONSTRUCT GAME
            //					
            // -- add some things to an object
            ThingList rm0list = new ThingList();
            rm0list.Add(new Thing("carrot", "It is a very crunchy carrot"));

            ThingList rm2list = new ThingList();
            rm2list.Add(new Thing("sausage", "It is a plump pork sausage"));

        
          

            /* MAP
             * 
             * meadow (0) - forest (1)
             *            |
             * glade (2) - grassy hill (3)
             */

            // -- create map											/N, S, W, E */
            /* 0 */
            _map.Add(Rm.Meadow, new Room("Meadow", "A beautiful grassy meadow.", Rm.NOEXIT, Rm.NOEXIT, Rm.NOEXIT, Rm.Forest, rm0list));
            /* 1 */
            _map.Add(Rm.Forest, new Room("Forest", "A gloomy forest that smells strongly of pine.", Rm.NOEXIT, Rm.Grassy_Hill, Rm.Meadow, Rm.NOEXIT, new ThingList()));
            /* 2 */
            _map.Add(Rm.Glade, new Room("Glade", "A sunny forest glade.", Rm.NOEXIT, Rm.NOEXIT, Rm.NOEXIT, Rm.Grassy_Hill, rm2list));
            /* 3 */
            _map.Add(Rm.Grassy_Hill, new Room("Grassy Hill", "A grassy mound.", Rm.Forest, Rm.NOEXIT, Rm.Glade, Rm.NOEXIT, new ThingList()));
           

            // -- add player to room0
            _player = new Actor("You", "The Player", _map.RoomAt(Rm.Meadow), new ThingList());

        }

        //// --- Player
        public Actor Player {
            get {
                return _player;
            }
        } // Player

        public RoomList Map { get => _map; set => _map = value; }


        // ========= Special Actions that control the game ==========
        //
        private void MoveActorTo(Actor anActor, Room aRoom) {
            anActor.CurrentRoom = aRoom;
        }

        private Rm MoveTo(Actor anActor, Dir direction) {
            Room r = anActor.CurrentRoom;
            Rm exit;

            switch (direction) {
                case Dir.NORTH:
                    exit = r.N;
                    break;
                case Dir.SOUTH:
                    exit = r.S;
                    break;
                case Dir.EAST:
                    exit = r.E;
                    break;
                case Dir.WEST:
                    exit = r.W;
                    break;
                default:
                    exit = Rm.NOEXIT;
                    break;
            }
            if (exit != Rm.NOEXIT) {
                MoveActorTo(anActor, _map.RoomAt(exit));
            }

            return exit;
        }

        public String MovePlayerTo(Dir direction) {
            string s = "";
            // returns string msg to display after attempting moveTo() operation
            if (MoveTo(_player, direction) == Rm.NOEXIT) {
                s =  "No Exit!";
            } else {
                s = _player.CurrentRoom.Describe();
            }
            return s;
        }

        private void TransferOb(Thing t, ThingList fromlist, ThingList tolist) {
            fromlist.Remove(t);
            tolist.Add(t);
        }

        public string TakeOb(string obname) {
            Thing t = _player.CurrentRoom.Things.ThisOb(obname);
            string s = "";
            if (obname == "") {
                obname = "nameless object"; // if no object specified
            }
            if (t == null) {
                s = "There is no " + obname + " here!";
            } else {
                if (t.CanTake) {
                    TransferOb(t, _player.CurrentRoom.Things, _player.Things);
                    s = t.Name + " taken!";
                } else {
                    s = "You can't take the " + t.Name + "!";
                }
            }
            return s;
        }

        // TODO: Let each object respond with any special actions ratherf than use this method!!!
        private string DropObSpecialAction(Thing t, Room r) {
            string s = "";
            if ((t.Name == "carrot") && (r.Name == "Kennel Room")) {
                // TODO: Create a puzzle. If the player drops the carrot here, 
                // the wombat comes out of kennel and eats carrot (once you've coded this!).
                s = "If you want the wombat to come out, you'll have to do some coding first!!!!";
            }
            return s;
        }

        public string DropOb(string obname) {
            Thing t = _player.Things.ThisOb(obname);
            string s = "";
            if (t == null) {
                s = "You haven't got one!";
            } else {
                TransferOb(t, _player.Things, _player.CurrentRoom.Things);
                s = t.Name + " dropped!" + DropObSpecialAction(t, _player.CurrentRoom); // check for any special actions ;
            }
            return s;
        }

        public string LookAtOb(string obname) {
            Thing t;
            string s = "";
            if (obname == "") {
                s = "You'll have to say what you want to look at!";
            } else {
                t = _player.CurrentRoom.Things.ThisOb(obname);
                if (t == null) {
                    t = _player.Things.ThisOb(obname);
                }
                if (t == null) {
                    s = "There is no " + obname + " here!";
                } else {
                    s = t.Description + ".";
                }                
            }
            return s;
        }

    } // Adventure
}
