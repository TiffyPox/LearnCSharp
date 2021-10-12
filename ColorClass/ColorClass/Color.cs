namespace ColorClass
{
    public class Color
    {
        private readonly byte _red;
        private byte _green;
        private byte _blue;
        private byte _alpha;

        public Color(byte red, byte green, byte blue, byte alpha)
        {
            this._red = red;
            this._green = green;
            this._blue = blue;
            this._alpha = alpha;
        }
        public Color(byte red, byte green, byte blue)
        {
            this._red = red;
            this._green = green;
            this._blue = blue;
            this._alpha = 255;
        }
        public byte Red { get; set; }
        public byte Green
        {
            get
            {
                return _green;
            }
            set
            {
                _green = value;
            }
        }
        public byte Blue
        {
            get
            {
                return _blue;
            }
            set
            {
                _blue = value;
            }
        }
        public byte Alpha
        {
            get
            {
                return _alpha;
            }
            set
            {
                _alpha = value;
            }
        }
        public byte Grayscale
        {
            get
            {
                return (byte)((_red + _green + _blue) / 3);
            }
        }
    }
}
