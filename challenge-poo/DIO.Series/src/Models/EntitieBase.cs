namespace DIO.Series.src
{
    public abstract class EntitieBase
    {

        public int Id { get; protected set; }
        public EntitieBase(int id)
        {
            this.Id = id;
        }
    }
}