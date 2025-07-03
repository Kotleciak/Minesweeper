namespace Minesweeper
{
    public class Field
    {
        public string ID { get; set; }
        public int Xindex { get; set; }
        public int Yindex { get; set; }
        public bool IsMine { get; set; }
        public int AdjacentMines { get; set; }
        public enum FieldState
        {
            Hidden,
            Revealed,
            Flagged,
        }
        public FieldState State { get; set; }

    }
}
