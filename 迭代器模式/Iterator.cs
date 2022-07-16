namespace DesignPattern
{
    public interface Iterator
    {
        bool MoveNext();
        void Reset();
        object GetCurrentObject();
        void Next();
    }
}