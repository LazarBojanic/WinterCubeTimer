
namespace WinterCubeTimer.model {
    public class Sticker {
        public int id { get; set; }
        public string colorName { get; set; }
        public string colorNameAsSide { get; set; }
        public Color color { get; set; }
        public Sticker() {
            id = 0;
            colorName = "";
            colorNameAsSide = "";
            color = new Color();
        }
        public Sticker(int id, string colorName, string colorNameAsSide, Color color) {
            this.id = id;
            this.colorName = colorName;
            this.colorNameAsSide = colorNameAsSide;
            this.color = color;
        }
        public void update(Sticker sticker) {
            id = sticker.id;
            colorName = sticker.colorName;
            colorNameAsSide = sticker.colorNameAsSide;
            color = sticker.color;
        }
    }
}
