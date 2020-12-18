namespace Interface.Classes
{
    public interface ICart
    {
        void Register(Product product);
        
        void List();

        void Alter(int code, Product newProduct);

        void Delete(int code);

    }
}