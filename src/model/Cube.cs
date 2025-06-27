using WinterCubeTimer.util;

namespace WinterCubeTimer.model {
    public class Cube {
        public List<Side> sides { get; set; }
        public Cube() {
            sides = [
                new Side("WHITE", Util.SIDE_UP, Util.COLOR_WHITE),
                new Side("RED", Util.SIDE_RIGHT, Util.COLOR_RED),
                new Side("GREEN", Util.SIDE_FRONT, Util.COLOR_GREEN),
                new Side("YELLOW", Util.SIDE_DOWN, Util.COLOR_YELLOW),
                new Side("ORANGE", Util.SIDE_LEFT, Util.COLOR_ORANGE),
                new Side("BLUE", Util.SIDE_BACK, Util.COLOR_BLUE)
            ];
        }
        public Cube(List<Side> newSides) {
            sides = newSides;
        }
        public Side getSide(string colorNameAsSide) {
            foreach (Side side in sides) {
                if (side.stickers[4].colorNameAsSide.Equals(colorNameAsSide)) {
                    return new Side(side);
                }
            }
            return new Side("WHITE", "U", Util.COLOR_WHITE);
        }
        public override string ToString() {
            string cubeString = "";
            //white side
            cubeString += " -  -  -  " + sides[0].stickers[0].color.Name[0] + " " + sides[0].stickers[1].color.Name[0] + " " + sides[0].stickers[2].color.Name[0] + "\n";
            cubeString += " -  -  -  " + sides[0].stickers[3].color.Name[0] + " " + sides[0].stickers[4].color.Name[0] + " " + sides[0].stickers[5].color.Name[0] + "\n";
            cubeString += " -  -  -  " + sides[0].stickers[6].color.Name[0] + " " + sides[0].stickers[7].color.Name[0] + " " + sides[0].stickers[8].color.Name[0] + "\n";
            //orange, green, red, blue sides
            cubeString += " " + sides[2].stickers[0].color.Name[0] + " " + sides[2].stickers[1].color.Name[0] + " " + sides[2].stickers[2].color.Name[0] +
                          " " + sides[4].stickers[0].color.Name[0] + " " + sides[4].stickers[1].color.Name[0] + " " + sides[4].stickers[2].color.Name[0] +
                          " " + sides[3].stickers[0].color.Name[0] + " " + sides[3].stickers[1].color.Name[0] + " " + sides[3].stickers[2].color.Name[0] +
                          " " + sides[5].stickers[0].color.Name[0] + " " + sides[5].stickers[1].color.Name[0] + " " + sides[5].stickers[2].color.Name[0] + "\n";
            cubeString += " " + sides[2].stickers[3].color.Name[0] + " " + sides[2].stickers[4].color.Name[0] + " " + sides[2].stickers[5].color.Name[0] +
                          " " + sides[4].stickers[3].color.Name[0] + " " + sides[4].stickers[4].color.Name[0] + " " + sides[4].stickers[5].color.Name[0] +
                          " " + sides[3].stickers[3].color.Name[0] + " " + sides[3].stickers[4].color.Name[0] + " " + sides[3].stickers[5].color.Name[0] +
                          " " + sides[5].stickers[3].color.Name[0] + " " + sides[5].stickers[4].color.Name[0] + " " + sides[5].stickers[5].color.Name[0] + "\n";
            cubeString += " " + sides[2].stickers[6].color.Name[0] + " " + sides[2].stickers[7].color.Name[0] + " " + sides[2].stickers[8].color.Name[0] +
                          " " + sides[4].stickers[6].color.Name[0] + " " + sides[4].stickers[7].color.Name[0] + " " + sides[4].stickers[8].color.Name[0] +
                          " " + sides[3].stickers[6].color.Name[0] + " " + sides[3].stickers[7].color.Name[0] + " " + sides[3].stickers[8].color.Name[0] +
                          " " + sides[5].stickers[6].color.Name[0] + " " + sides[5].stickers[7].color.Name[0] + " " + sides[5].stickers[8].color.Name[0] + "\n";
            //yellow side
            cubeString += " -  -  -  " + sides[1].stickers[0].color.Name[0] + " " + sides[1].stickers[1].color.Name[0] + " " + sides[1].stickers[2].color.Name[0] + "\n";
            cubeString += " -  -  -  " + sides[1].stickers[3].color.Name[0] + " " + sides[1].stickers[4].color.Name[0] + " " + sides[1].stickers[5].color.Name[0] + "\n";
            cubeString += " -  -  -  " + sides[1].stickers[6].color.Name[0] + " " + sides[1].stickers[7].color.Name[0] + " " + sides[1].stickers[8].color.Name[0] + "\n";
            return cubeString;
        }
        
        public static Cube getTurnedCube(Cube cube, string turn) {
            Side currentUpSide = cube.getSide("U");
            Side currentDownSide = cube.getSide("D");
            Side currentLeftSide = cube.getSide("L");
            Side currentRightSide = cube.getSide( "R");
            Side currentFrontSide = cube.getSide("F");
            Side currentBackSide = cube.getSide("B");
            
            Side newUpSide = new Side(currentUpSide);
            Side newDownSide = new Side(currentDownSide);
            Side newLeftSide = new Side(currentLeftSide);
            Side newRightSide = new Side(currentRightSide);
            Side newFrontSide = new Side(currentFrontSide);
            Side newBackSide = new Side(currentBackSide);

            if (turn.Equals("U")) {
                newUpSide.stickers[2].update(currentUpSide.stickers[0]);
                newUpSide.stickers[8].update(currentUpSide.stickers[2]);
                newUpSide.stickers[6].update(currentUpSide.stickers[8]);
                newUpSide.stickers[0].update(currentUpSide.stickers[6]);
                newUpSide.stickers[5].update(currentUpSide.stickers[1]);
                newUpSide.stickers[7].update(currentUpSide.stickers[5]);
                newUpSide.stickers[3].update(currentUpSide.stickers[7]);
                newUpSide.stickers[1].update(currentUpSide.stickers[3]);

                newRightSide.stickers[0].update(currentBackSide.stickers[0]);
                newRightSide.stickers[2].update(currentBackSide.stickers[2]);
                newRightSide.stickers[1].update(currentBackSide.stickers[1]);

                newFrontSide.stickers[0].update(currentRightSide.stickers[0]);
                newFrontSide.stickers[2].update(currentRightSide.stickers[2]);
                newFrontSide.stickers[1].update(currentRightSide.stickers[1]);

                newLeftSide.stickers[0].update(currentFrontSide.stickers[0]);
                newLeftSide.stickers[2].update(currentFrontSide.stickers[2]);
                newLeftSide.stickers[1].update(currentFrontSide.stickers[1]);

                newBackSide.stickers[0].update(currentLeftSide.stickers[0]);
                newBackSide.stickers[2].update(currentLeftSide.stickers[2]);
                newBackSide.stickers[1].update(currentLeftSide.stickers[1]);
            }
            if (turn.Equals("U'")) {
                newUpSide.stickers[0].update(currentUpSide.stickers[2]);
                newUpSide.stickers[6].update(currentUpSide.stickers[0]);
                newUpSide.stickers[8].update(currentUpSide.stickers[6]);
                newUpSide.stickers[2].update(currentUpSide.stickers[8]);
                newUpSide.stickers[3].update(currentUpSide.stickers[1]);
                newUpSide.stickers[7].update(currentUpSide.stickers[3]);
                newUpSide.stickers[5].update(currentUpSide.stickers[7]);
                newUpSide.stickers[1].update(currentUpSide.stickers[5]);

                newLeftSide.stickers[0].update(currentBackSide.stickers[0]);
                newLeftSide.stickers[2].update(currentBackSide.stickers[2]);
                newLeftSide.stickers[1].update(currentBackSide.stickers[1]);

                newFrontSide.stickers[0].update(currentLeftSide.stickers[0]);
                newFrontSide.stickers[2].update(currentLeftSide.stickers[2]);
                newFrontSide.stickers[1].update(currentLeftSide.stickers[1]);

                newRightSide.stickers[0].update(currentFrontSide.stickers[0]);
                newRightSide.stickers[2].update(currentFrontSide.stickers[2]);
                newRightSide.stickers[1].update(currentFrontSide.stickers[1]);

                newBackSide.stickers[0].update(currentRightSide.stickers[0]);
                newBackSide.stickers[2].update(currentRightSide.stickers[2]);
                newBackSide.stickers[1].update(currentRightSide.stickers[1]);
            }
            if (turn.Equals("U2")) {
                newUpSide.stickers[8].update(currentUpSide.stickers[0]);
                newUpSide.stickers[0].update(currentUpSide.stickers[8]);
                newUpSide.stickers[6].update(currentUpSide.stickers[2]);
                newUpSide.stickers[2].update(currentUpSide.stickers[6]);
                newUpSide.stickers[5].update(currentUpSide.stickers[3]);
                newUpSide.stickers[3].update(currentUpSide.stickers[5]);
                newUpSide.stickers[7].update(currentUpSide.stickers[1]);
                newUpSide.stickers[1].update(currentUpSide.stickers[7]);

                newRightSide.stickers[0].update(currentLeftSide.stickers[0]);
                newRightSide.stickers[2].update(currentLeftSide.stickers[2]);
                newRightSide.stickers[1].update(currentLeftSide.stickers[1]);

                newLeftSide.stickers[0].update(currentRightSide.stickers[0]);
                newLeftSide.stickers[2].update(currentRightSide.stickers[2]);
                newLeftSide.stickers[1].update(currentRightSide.stickers[1]);

                newBackSide.stickers[0].update(currentFrontSide.stickers[0]);
                newBackSide.stickers[2].update(currentFrontSide.stickers[2]);
                newBackSide.stickers[1].update(currentFrontSide.stickers[1]);

                newFrontSide.stickers[0].update(currentBackSide.stickers[0]);
                newFrontSide.stickers[2].update(currentBackSide.stickers[2]);
                newFrontSide.stickers[1].update(currentBackSide.stickers[1]);
            }
            if (turn.Equals("D")) {
                newDownSide.stickers[2].update(currentDownSide.stickers[0]);
                newDownSide.stickers[8].update(currentDownSide.stickers[2]);
                newDownSide.stickers[6].update(currentDownSide.stickers[8]);
                newDownSide.stickers[0].update(currentDownSide.stickers[6]);
                newDownSide.stickers[5].update(currentDownSide.stickers[1]);
                newDownSide.stickers[7].update(currentDownSide.stickers[5]);
                newDownSide.stickers[3].update(currentDownSide.stickers[7]);
                newDownSide.stickers[1].update(currentDownSide.stickers[3]);

                newRightSide.stickers[6].update(currentFrontSide.stickers[6]);
                newRightSide.stickers[8].update(currentFrontSide.stickers[8]);
                newRightSide.stickers[7].update(currentFrontSide.stickers[7]);

                newBackSide.stickers[6].update(currentRightSide.stickers[6]);
                newBackSide.stickers[8].update(currentRightSide.stickers[8]);
                newBackSide.stickers[7].update(currentRightSide.stickers[7]);

                newLeftSide.stickers[6].update(currentBackSide.stickers[6]);
                newLeftSide.stickers[8].update(currentBackSide.stickers[8]);
                newLeftSide.stickers[7].update(currentBackSide.stickers[7]);

                newFrontSide.stickers[6].update(currentLeftSide.stickers[6]);
                newFrontSide.stickers[8].update(currentLeftSide.stickers[8]);
                newFrontSide.stickers[7].update(currentLeftSide.stickers[7]);
            }
            if (turn.Equals("D'")) {
                newDownSide.stickers[0].update(currentDownSide.stickers[2]);
                newDownSide.stickers[6].update(currentDownSide.stickers[0]);
                newDownSide.stickers[8].update(currentDownSide.stickers[6]);
                newDownSide.stickers[2].update(currentDownSide.stickers[8]);
                newDownSide.stickers[3].update(currentDownSide.stickers[1]);
                newDownSide.stickers[7].update(currentDownSide.stickers[3]);
                newDownSide.stickers[5].update(currentDownSide.stickers[7]);
                newDownSide.stickers[1].update(currentDownSide.stickers[5]);

                newRightSide.stickers[6].update(currentBackSide.stickers[6]);
                newRightSide.stickers[8].update(currentBackSide.stickers[8]);
                newRightSide.stickers[7].update(currentBackSide.stickers[7]);

                newFrontSide.stickers[6].update(currentRightSide.stickers[6]);
                newFrontSide.stickers[8].update(currentRightSide.stickers[8]);
                newFrontSide.stickers[7].update(currentRightSide.stickers[7]);

                newLeftSide.stickers[6].update(currentFrontSide.stickers[6]);
                newLeftSide.stickers[8].update(currentFrontSide.stickers[8]);
                newLeftSide.stickers[7].update(currentFrontSide.stickers[7]);

                newBackSide.stickers[6].update(currentLeftSide.stickers[6]);
                newBackSide.stickers[8].update(currentLeftSide.stickers[8]);
                newBackSide.stickers[7].update(currentLeftSide.stickers[7]);
            }
            if (turn.Equals("D2")) {
                newDownSide.stickers[8].update(currentDownSide.stickers[0]);
                newDownSide.stickers[0].update(currentDownSide.stickers[8]);
                newDownSide.stickers[6].update(currentDownSide.stickers[2]);
                newDownSide.stickers[2].update(currentDownSide.stickers[6]);
                newDownSide.stickers[5].update(currentDownSide.stickers[3]);
                newDownSide.stickers[3].update(currentDownSide.stickers[5]);
                newDownSide.stickers[7].update(currentDownSide.stickers[1]);
                newDownSide.stickers[1].update(currentDownSide.stickers[7]);

                newRightSide.stickers[6].update(currentLeftSide.stickers[6]);
                newRightSide.stickers[8].update(currentLeftSide.stickers[8]);
                newRightSide.stickers[7].update(currentLeftSide.stickers[7]);

                newLeftSide.stickers[6].update(currentRightSide.stickers[6]);
                newLeftSide.stickers[8].update(currentRightSide.stickers[8]);
                newLeftSide.stickers[7].update(currentRightSide.stickers[7]);

                newBackSide.stickers[6].update(currentFrontSide.stickers[6]);
                newBackSide.stickers[8].update(currentFrontSide.stickers[8]);
                newBackSide.stickers[7].update(currentFrontSide.stickers[7]);

                newFrontSide.stickers[6].update(currentBackSide.stickers[6]);
                newFrontSide.stickers[8].update(currentBackSide.stickers[8]);
                newFrontSide.stickers[7].update(currentBackSide.stickers[7]);
            }
            if (turn.Equals("L")) {
                newLeftSide.stickers[2].update(currentLeftSide.stickers[0]);
                newLeftSide.stickers[8].update(currentLeftSide.stickers[2]);
                newLeftSide.stickers[6].update(currentLeftSide.stickers[8]);
                newLeftSide.stickers[0].update(currentLeftSide.stickers[6]);
                newLeftSide.stickers[5].update(currentLeftSide.stickers[1]);
                newLeftSide.stickers[7].update(currentLeftSide.stickers[5]);
                newLeftSide.stickers[3].update(currentLeftSide.stickers[7]);
                newLeftSide.stickers[1].update(currentLeftSide.stickers[3]);

                newFrontSide.stickers[6].update(currentUpSide.stickers[6]);
                newFrontSide.stickers[0].update(currentUpSide.stickers[0]);
                newFrontSide.stickers[3].update(currentUpSide.stickers[3]);

                newDownSide.stickers[6].update(currentFrontSide.stickers[6]);
                newDownSide.stickers[0].update(currentFrontSide.stickers[0]);
                newDownSide.stickers[3].update(currentFrontSide.stickers[3]);

                newBackSide.stickers[2].update(currentDownSide.stickers[6]);
                newBackSide.stickers[8].update(currentDownSide.stickers[0]);
                newBackSide.stickers[5].update(currentDownSide.stickers[3]);

                newUpSide.stickers[6].update(currentBackSide.stickers[2]);
                newUpSide.stickers[0].update(currentBackSide.stickers[8]);
                newUpSide.stickers[3].update(currentBackSide.stickers[5]);
            }
            if (turn.Equals("L'")) {
                newLeftSide.stickers[0].update(currentLeftSide.stickers[2]);
                newLeftSide.stickers[6].update(currentLeftSide.stickers[0]);
                newLeftSide.stickers[8].update(currentLeftSide.stickers[6]);
                newLeftSide.stickers[2].update(currentLeftSide.stickers[8]);
                newLeftSide.stickers[3].update(currentLeftSide.stickers[1]);
                newLeftSide.stickers[7].update(currentLeftSide.stickers[3]);
                newLeftSide.stickers[5].update(currentLeftSide.stickers[7]);
                newLeftSide.stickers[1].update(currentLeftSide.stickers[5]);

                newBackSide.stickers[2].update(currentUpSide.stickers[6]);
                newBackSide.stickers[8].update(currentUpSide.stickers[0]);
                newBackSide.stickers[5].update(currentUpSide.stickers[3]);

                newDownSide.stickers[6].update(currentBackSide.stickers[2]);
                newDownSide.stickers[0].update(currentBackSide.stickers[8]);
                newDownSide.stickers[3].update(currentBackSide.stickers[5]);

                newFrontSide.stickers[6].update(currentDownSide.stickers[6]);
                newFrontSide.stickers[0].update(currentDownSide.stickers[0]);
                newFrontSide.stickers[3].update(currentDownSide.stickers[3]);

                newUpSide.stickers[6].update(currentFrontSide.stickers[6]);
                newUpSide.stickers[0].update(currentFrontSide.stickers[0]);
                newUpSide.stickers[3].update(currentFrontSide.stickers[3]);
            }
            if (turn.Equals("L2")) {
                newLeftSide.stickers[8].update(currentLeftSide.stickers[0]);
                newLeftSide.stickers[0].update(currentLeftSide.stickers[8]);
                newLeftSide.stickers[6].update(currentLeftSide.stickers[2]);
                newLeftSide.stickers[2].update(currentLeftSide.stickers[6]);
                newLeftSide.stickers[5].update(currentLeftSide.stickers[3]);
                newLeftSide.stickers[3].update(currentLeftSide.stickers[5]);
                newLeftSide.stickers[7].update(currentLeftSide.stickers[1]);
                newLeftSide.stickers[1].update(currentLeftSide.stickers[7]);

                newDownSide.stickers[6].update(currentUpSide.stickers[6]);
                newDownSide.stickers[0].update(currentUpSide.stickers[0]);
                newDownSide.stickers[3].update(currentUpSide.stickers[3]);

                newUpSide.stickers[6].update(currentDownSide.stickers[6]);
                newUpSide.stickers[0].update(currentDownSide.stickers[0]);
                newUpSide.stickers[3].update(currentDownSide.stickers[3]);

                newBackSide.stickers[2].update(currentFrontSide.stickers[6]);
                newBackSide.stickers[8].update(currentFrontSide.stickers[0]);
                newBackSide.stickers[5].update(currentFrontSide.stickers[3]);

                newFrontSide.stickers[6].update(currentBackSide.stickers[2]);
                newFrontSide.stickers[0].update(currentBackSide.stickers[8]);
                newFrontSide.stickers[3].update(currentBackSide.stickers[5]);
            }
            if (turn.Equals("R")) {
                newRightSide.stickers[2].update(currentRightSide.stickers[0]);
                newRightSide.stickers[8].update(currentRightSide.stickers[2]);
                newRightSide.stickers[6].update(currentRightSide.stickers[8]);
                newRightSide.stickers[0].update(currentRightSide.stickers[6]);
                newRightSide.stickers[5].update(currentRightSide.stickers[1]);
                newRightSide.stickers[7].update(currentRightSide.stickers[5]);
                newRightSide.stickers[3].update(currentRightSide.stickers[7]);
                newRightSide.stickers[1].update(currentRightSide.stickers[3]);

                newBackSide.stickers[6].update(currentUpSide.stickers[2]);
                newBackSide.stickers[0].update(currentUpSide.stickers[8]);
                newBackSide.stickers[3].update(currentUpSide.stickers[5]);

                newDownSide.stickers[2].update(currentBackSide.stickers[6]);
                newDownSide.stickers[8].update(currentBackSide.stickers[0]);
                newDownSide.stickers[5].update(currentBackSide.stickers[3]);

                newFrontSide.stickers[2].update(currentDownSide.stickers[2]);
                newFrontSide.stickers[8].update(currentDownSide.stickers[8]);
                newFrontSide.stickers[5].update(currentDownSide.stickers[5]);

                newUpSide.stickers[2].update(currentFrontSide.stickers[2]);
                newUpSide.stickers[8].update(currentFrontSide.stickers[8]);
                newUpSide.stickers[5].update(currentFrontSide.stickers[5]);
            }
            if (turn.Equals("R'")) {
                newRightSide.stickers[0].update(currentRightSide.stickers[2]);
                newRightSide.stickers[6].update(currentRightSide.stickers[0]);
                newRightSide.stickers[8].update(currentRightSide.stickers[6]);
                newRightSide.stickers[2].update(currentRightSide.stickers[8]);
                newRightSide.stickers[3].update(currentRightSide.stickers[1]);
                newRightSide.stickers[7].update(currentRightSide.stickers[3]);
                newRightSide.stickers[5].update(currentRightSide.stickers[7]);
                newRightSide.stickers[1].update(currentRightSide.stickers[5]);

                newFrontSide.stickers[2].update(currentUpSide.stickers[2]);
                newFrontSide.stickers[8].update(currentUpSide.stickers[8]);
                newFrontSide.stickers[5].update(currentUpSide.stickers[5]);

                newDownSide.stickers[2].update(currentFrontSide.stickers[2]);
                newDownSide.stickers[8].update(currentFrontSide.stickers[8]);
                newDownSide.stickers[5].update(currentFrontSide.stickers[5]);

                newBackSide.stickers[6].update(currentDownSide.stickers[2]);
                newBackSide.stickers[0].update(currentDownSide.stickers[8]);
                newBackSide.stickers[3].update(currentDownSide.stickers[5]);

                newUpSide.stickers[2].update(currentBackSide.stickers[6]);
                newUpSide.stickers[8].update(currentBackSide.stickers[0]);
                newUpSide.stickers[5].update(currentBackSide.stickers[3]);
            }
            if (turn.Equals("R2")) {
                newRightSide.stickers[8].update(currentRightSide.stickers[0]);
                newRightSide.stickers[0].update(currentRightSide.stickers[8]);
                newRightSide.stickers[6].update(currentRightSide.stickers[2]);
                newRightSide.stickers[2].update(currentRightSide.stickers[6]);
                newRightSide.stickers[5].update(currentRightSide.stickers[3]);
                newRightSide.stickers[3].update(currentRightSide.stickers[5]);
                newRightSide.stickers[7].update(currentRightSide.stickers[1]);
                newRightSide.stickers[1].update(currentRightSide.stickers[7]);

                newDownSide.stickers[2].update(currentUpSide.stickers[2]);
                newDownSide.stickers[8].update(currentUpSide.stickers[8]);
                newDownSide.stickers[5].update(currentUpSide.stickers[5]);

                newUpSide.stickers[2].update(currentDownSide.stickers[2]);
                newUpSide.stickers[8].update(currentDownSide.stickers[8]);
                newUpSide.stickers[5].update(currentDownSide.stickers[5]);

                newBackSide.stickers[6].update(currentFrontSide.stickers[2]);
                newBackSide.stickers[0].update(currentFrontSide.stickers[8]);
                newBackSide.stickers[3].update(currentFrontSide.stickers[5]);

                newFrontSide.stickers[2].update(currentBackSide.stickers[6]);
                newFrontSide.stickers[8].update(currentBackSide.stickers[0]);
                newFrontSide.stickers[5].update(currentBackSide.stickers[3]);
            }
            if (turn.Equals("F")) {
                newFrontSide.stickers[2].update(currentFrontSide.stickers[0]);
                newFrontSide.stickers[8].update(currentFrontSide.stickers[2]);
                newFrontSide.stickers[6].update(currentFrontSide.stickers[8]);
                newFrontSide.stickers[0].update(currentFrontSide.stickers[6]);
                newFrontSide.stickers[5].update(currentFrontSide.stickers[1]);
                newFrontSide.stickers[7].update(currentFrontSide.stickers[5]);
                newFrontSide.stickers[3].update(currentFrontSide.stickers[7]);
                newFrontSide.stickers[1].update(currentFrontSide.stickers[3]);

                newRightSide.stickers[6].update(currentUpSide.stickers[8]);
                newRightSide.stickers[0].update(currentUpSide.stickers[6]);
                newRightSide.stickers[3].update(currentUpSide.stickers[7]);

                newDownSide.stickers[0].update(currentRightSide.stickers[6]);
                newDownSide.stickers[2].update(currentRightSide.stickers[0]);
                newDownSide.stickers[1].update(currentRightSide.stickers[3]);

                newLeftSide.stickers[2].update(currentDownSide.stickers[0]);
                newLeftSide.stickers[8].update(currentDownSide.stickers[2]);
                newLeftSide.stickers[5].update(currentDownSide.stickers[1]);

                newUpSide.stickers[8].update(currentLeftSide.stickers[2]);
                newUpSide.stickers[6].update(currentLeftSide.stickers[8]);
                newUpSide.stickers[7].update(currentLeftSide.stickers[5]);
            }
            if (turn.Equals("F'")) {
                newFrontSide.stickers[0].update(currentFrontSide.stickers[2]);
                newFrontSide.stickers[6].update(currentFrontSide.stickers[0]);
                newFrontSide.stickers[8].update(currentFrontSide.stickers[6]);
                newFrontSide.stickers[2].update(currentFrontSide.stickers[8]);
                newFrontSide.stickers[3].update(currentFrontSide.stickers[1]);
                newFrontSide.stickers[7].update(currentFrontSide.stickers[3]);
                newFrontSide.stickers[5].update(currentFrontSide.stickers[7]);
                newFrontSide.stickers[1].update(currentFrontSide.stickers[5]);

                newLeftSide.stickers[2].update(currentUpSide.stickers[8]);
                newLeftSide.stickers[8].update(currentUpSide.stickers[6]);
                newLeftSide.stickers[5].update(currentUpSide.stickers[7]);

                newDownSide.stickers[0].update(currentLeftSide.stickers[2]);
                newDownSide.stickers[2].update(currentLeftSide.stickers[8]);
                newDownSide.stickers[1].update(currentLeftSide.stickers[5]);

                newRightSide.stickers[6].update(currentDownSide.stickers[0]);
                newRightSide.stickers[0].update(currentDownSide.stickers[2]);
                newRightSide.stickers[3].update(currentDownSide.stickers[1]);

                newUpSide.stickers[6].update(currentRightSide.stickers[0]);
                newUpSide.stickers[8].update(currentRightSide.stickers[6]);
                newUpSide.stickers[7].update(currentRightSide.stickers[3]);
            }
            if (turn.Equals("F2")) {
                newFrontSide.stickers[8].update(currentFrontSide.stickers[0]);
                newFrontSide.stickers[0].update(currentFrontSide.stickers[8]);
                newFrontSide.stickers[6].update(currentFrontSide.stickers[2]);
                newFrontSide.stickers[2].update(currentFrontSide.stickers[6]);
                newFrontSide.stickers[5].update(currentFrontSide.stickers[3]);
                newFrontSide.stickers[3].update(currentFrontSide.stickers[5]);
                newFrontSide.stickers[7].update(currentFrontSide.stickers[1]);
                newFrontSide.stickers[1].update(currentFrontSide.stickers[7]);

                newDownSide.stickers[0].update(currentUpSide.stickers[8]);
                newDownSide.stickers[2].update(currentUpSide.stickers[6]);
                newDownSide.stickers[1].update(currentUpSide.stickers[7]);

                newUpSide.stickers[8].update(currentDownSide.stickers[0]);
                newUpSide.stickers[6].update(currentDownSide.stickers[2]);
                newUpSide.stickers[7].update(currentDownSide.stickers[1]);

                newRightSide.stickers[0].update(currentLeftSide.stickers[8]);
                newRightSide.stickers[6].update(currentLeftSide.stickers[2]);
                newRightSide.stickers[3].update(currentLeftSide.stickers[5]);

                newLeftSide.stickers[8].update(currentRightSide.stickers[0]);
                newLeftSide.stickers[2].update(currentRightSide.stickers[6]);
                newLeftSide.stickers[5].update(currentRightSide.stickers[3]);
            }
            if (turn.Equals("B")) {
                newBackSide.stickers[2].update(currentBackSide.stickers[0]);
                newBackSide.stickers[8].update(currentBackSide.stickers[2]);
                newBackSide.stickers[6].update(currentBackSide.stickers[8]);
                newBackSide.stickers[0].update(currentBackSide.stickers[6]);
                newBackSide.stickers[5].update(currentBackSide.stickers[1]);
                newBackSide.stickers[7].update(currentBackSide.stickers[5]);
                newBackSide.stickers[3].update(currentBackSide.stickers[7]);
                newBackSide.stickers[1].update(currentBackSide.stickers[3]);

                newLeftSide.stickers[6].update(currentUpSide.stickers[0]);
                newLeftSide.stickers[0].update(currentUpSide.stickers[2]);
                newLeftSide.stickers[3].update(currentUpSide.stickers[1]);

                newDownSide.stickers[8].update(currentLeftSide.stickers[6]);
                newDownSide.stickers[6].update(currentLeftSide.stickers[0]);
                newDownSide.stickers[7].update(currentLeftSide.stickers[3]);

                newRightSide.stickers[2].update(currentDownSide.stickers[8]);
                newRightSide.stickers[8].update(currentDownSide.stickers[6]);
                newRightSide.stickers[5].update(currentDownSide.stickers[7]);

                newUpSide.stickers[0].update(currentRightSide.stickers[2]);
                newUpSide.stickers[2].update(currentRightSide.stickers[8]);
                newUpSide.stickers[1].update(currentRightSide.stickers[5]);
            }
            if (turn.Equals("B'")) {
                newBackSide.stickers[0].update(currentBackSide.stickers[2]);
                newBackSide.stickers[6].update(currentBackSide.stickers[0]);
                newBackSide.stickers[8].update(currentBackSide.stickers[6]);
                newBackSide.stickers[2].update(currentBackSide.stickers[8]);
                newBackSide.stickers[3].update(currentBackSide.stickers[1]);
                newBackSide.stickers[7].update(currentBackSide.stickers[3]);
                newBackSide.stickers[5].update(currentBackSide.stickers[7]);
                newBackSide.stickers[1].update(currentBackSide.stickers[5]);

                newRightSide.stickers[2].update(currentUpSide.stickers[0]);
                newRightSide.stickers[8].update(currentUpSide.stickers[2]);
                newRightSide.stickers[5].update(currentUpSide.stickers[1]);

                newDownSide.stickers[8].update(currentRightSide.stickers[2]);
                newDownSide.stickers[6].update(currentRightSide.stickers[8]);
                newDownSide.stickers[7].update(currentRightSide.stickers[5]);

                newLeftSide.stickers[6].update(currentDownSide.stickers[8]);
                newLeftSide.stickers[0].update(currentDownSide.stickers[6]);
                newLeftSide.stickers[3].update(currentDownSide.stickers[7]);

                newUpSide.stickers[0].update(currentLeftSide.stickers[6]);
                newUpSide.stickers[2].update(currentLeftSide.stickers[0]);
                newUpSide.stickers[1].update(currentLeftSide.stickers[3]);
            }
            if (turn.Equals("B2")) {
                newBackSide.stickers[8].update(currentBackSide.stickers[0]);
                newBackSide.stickers[0].update(currentBackSide.stickers[8]);
                newBackSide.stickers[6].update(currentBackSide.stickers[2]);
                newBackSide.stickers[2].update(currentBackSide.stickers[6]);
                newBackSide.stickers[5].update(currentBackSide.stickers[3]);
                newBackSide.stickers[3].update(currentBackSide.stickers[5]);
                newBackSide.stickers[7].update(currentBackSide.stickers[1]);
                newBackSide.stickers[1].update(currentBackSide.stickers[7]);

                newDownSide.stickers[8].update(currentUpSide.stickers[0]);
                newDownSide.stickers[6].update(currentUpSide.stickers[2]);
                newDownSide.stickers[7].update(currentUpSide.stickers[1]);

                newUpSide.stickers[0].update(currentDownSide.stickers[8]);
                newUpSide.stickers[2].update(currentDownSide.stickers[6]);
                newUpSide.stickers[1].update(currentDownSide.stickers[7]);

                newRightSide.stickers[2].update(currentLeftSide.stickers[6]);
                newRightSide.stickers[8].update(currentLeftSide.stickers[0]);
                newRightSide.stickers[5].update(currentLeftSide.stickers[3]);

                newLeftSide.stickers[6].update(currentRightSide.stickers[2]);
                newLeftSide.stickers[0].update(currentRightSide.stickers[8]);
                newLeftSide.stickers[3].update(currentRightSide.stickers[5]);
            }
            List<Side> newSides = [newUpSide, newRightSide, newFrontSide, newDownSide, newLeftSide, newBackSide];
            return new Cube(newSides);
        }

        public static Cube applyScramble(Cube cube, List<string> scramble) {
            foreach (string turn in scramble) {
                cube = getTurnedCube(cube, turn);
            }
            return cube;
        }
    }
}