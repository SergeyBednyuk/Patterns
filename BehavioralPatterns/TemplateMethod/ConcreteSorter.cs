namespace TemplateMethod
{
    class ConcreteSorter : Sorter
    {
        public ConcreteSorter(params int[] source) : base(source)
        { 
        }

        protected override bool Compare(int x, int y)
        {
            return x < y;
        }
    }
}
