namespace Khoassant.Objects.Sudoku
{
    public class SudokuTile
    {
        public int Row { get; set; }
        public int Col { get; set; }
        public List<int> PossibleValues { get; set; } = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 }; // by default, a tile can have any value

        public int CurrentValue { get; set; }

        public List<SudokuTile> ColNeighbors { get; set; } = new List<SudokuTile>();

        public List<SudokuTile> RowNeighbors { get; set; } = new List<SudokuTile>();

        public List<SudokuTile> AdjacentNeighbors { get; set; } = new List<SudokuTile>();

        public void SetValue(int i)
        {
            CurrentValue = i;
            Update();
        }

        public void Update()
        {
            if (PossibleValues.Count == 1)
            {
                CurrentValue = PossibleValues[0];
            }

            if (PossibleValues.Count == 0)
            {
                return;
            }

            if (CurrentValue != 0)
            {

            }
        }
    }
}
