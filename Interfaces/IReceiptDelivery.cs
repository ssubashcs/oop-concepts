using ObjectOrientedProgramming.SRP;

namespace ObjectOrientedProgramming.Interfaces
{
    public interface IReceiptDelivery
    {
        void Deliver(CheckoutReceipt receipt);
    }

    public sealed class ConsoleReceiptDelivery : IReceiptDelivery
    {
        public void Deliver(CheckoutReceipt receipt)
        {
            ArgumentNullException.ThrowIfNull(receipt);

            Console.WriteLine(ReceiptFormatter.Format(receipt));
        }
    }

    public sealed class FileReceiptDelivery : IReceiptDelivery
    {
        private readonly string _directoryPath;

        public FileReceiptDelivery(string filePath)
        {
            ArgumentException.ThrowIfNullOrWhiteSpace(filePath);

            _directoryPath = filePath;
        }

        public void Deliver(CheckoutReceipt receipt)
        {
            ArgumentNullException.ThrowIfNull(receipt);

            string result = ReceiptFormatter.Format(receipt);

            File.WriteAllText(Path.Combine(_directoryPath, "receipt.txt"), result);

            Console.WriteLine("Receipt file stored successfully.");
        }
    }
}
