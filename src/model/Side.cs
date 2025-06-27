using WinterCubeTimer.util;

namespace WinterCubeTimer.model {
    public class Side {
        public List<Sticker> stickers { get; set; }
        public Side(string colorName, string colorNameAsSide, Color color) {
            stickers = new List<Sticker>();
            for (int i = 0; i < 9; i++) {
                stickers.Add(new Sticker(i, colorName, colorNameAsSide, color));
            }
        }
        public Side(List<Sticker> stickers) {
            this.stickers = stickers;
        }
        public Side(Side side) {
            List<Sticker> newStickers = [];
            foreach (Sticker sticker in side.stickers) {
                Sticker newSticker = new Sticker(sticker.id, sticker.colorName, sticker.colorNameAsSide, sticker.color);
                newStickers.Add(newSticker);
            }
            stickers = newStickers;
        }
        
        public override string ToString() {
            string stickersString = "";
            stickersString += " " + stickers[0].colorNameAsSide + " " + stickers[1].colorNameAsSide + " " + stickers[2].colorNameAsSide + "\n";
            stickersString += " " + stickers[3].colorNameAsSide + " " + stickers[4].colorNameAsSide + " " + stickers[5].colorNameAsSide + "\n";
            stickersString += " " + stickers[6].colorNameAsSide + " " + stickers[7].colorNameAsSide + " " + stickers[8].colorNameAsSide + "\n";
            return stickersString;
        }
    }
}