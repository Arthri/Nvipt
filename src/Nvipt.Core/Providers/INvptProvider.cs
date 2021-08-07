namespace Nvipt.Providers
{
    public interface INvptProvider
    {
        void Initialize();
        bool Add(Nvpt nvpt);
        bool AddOrUpdate(Nvpt nvpt);
        Nvpt Get(int owner, string name);
        bool Rename(int owner, string oldName, string newName);
        bool Update(int owner, string name, Inventory inventory);
        bool Delete(int owner, string name);
    }
}
