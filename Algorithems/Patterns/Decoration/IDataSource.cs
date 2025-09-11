namespace Algorithems.Patterns.Decoration
{
    public interface IDataSource
    {
        void WriteData(string data);
        string ReadData();
    }

    public class FileDataSource : IDataSource
    {
        private string _data;
        public FileDataSource(string data)
        {
            _data = data;
        }
        public string ReadData()
        {
            Console.WriteLine("[File] Reading data...");
            return _data;
        }

        public void WriteData(string data)
        {
            Console.WriteLine($"[File] Writing: {data}");
            _data = data;
        }
    }

    public abstract class DataSourceDecorator : IDataSource
    {
        private readonly IDataSource _dataSource;
        public DataSourceDecorator(IDataSource dataSource)
        {
            _dataSource = dataSource;
        }
        public virtual string ReadData() => _dataSource.ReadData();

        public virtual void WriteData(string data) => _dataSource.WriteData(data);
    }

    public class CompressionDecorator : DataSourceDecorator
    {

        public CompressionDecorator(IDataSource dataSource) : base(dataSource)
        {
        }

        public override string ReadData()
        {
            var data = base.ReadData();
            return data.Replace("[Compressed]", "");
        }

        public override void WriteData(string data)
        {
            var compressed = $"[Compressed]{data}";
              Console.WriteLine("Compressing data...");
            base.WriteData(compressed);
        }
    }

}