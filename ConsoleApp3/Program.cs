namespace ConsoleApp2
{

    public class WebC
    {
        private string name;
        public string path;
        public string url;
        public string describe;

        public string Name { get; set; }
        public string Path { get; set; }
        public string Url { get; set; }
        public string Describe { get; set; }

        public override string ToString()
        {
            return $"Name: {name}\n Path: {path}\n Url: {url}\n Describe: {describe}\n";
        }

        public void Input(string name, string path, string url, string describe)
        {
            this.name = name;
            this.path = path;
            this.url = url;
            this.describe = describe;
        }
    }

    public class Journal
    {
        private string title;
        public int yearOfFoundation;
        public string description;
        public string contactPhone;
        public string contactEmail;

        public string Title { get; set; }
        public int YearOfFoundation { get; set; }
        public string Description { get; set; }
        public string ContactPhone { get; set; }
        public string ContactEmail { get; set; }

        public override string ToString()
        {
            return $"Title: {title}\n Year of Foundation: {yearOfFoundation}\n Description: {description}\n Contact Phone: {contactPhone}\n Contact Email: {contactEmail}\n";
        }

        public void Input(string title, int yearOfFoundation, string description, string contactPhone, string contactEmail)
        {
            this.title = title;
            this.yearOfFoundation = yearOfFoundation;
            this.description = description;
            this.contactPhone = contactPhone;
            this.contactEmail = contactEmail;
        }
    }

    public class Store
    {
        private string storeName;
        public string address;
        public string storeProfile;
        public string contactPhone;
        public string contactEmail;

        public string StoreName { get; set; }
        public string Address { get; set; }
        public string StoreProfile { get; set; }
        public string ContactPhone { get; set; }
        public string ContactEmail { get; set; }

        public override string ToString()
        {
            return $"Store Name: {storeName}\n Address: {address}\n Store Profile: {storeProfile}\n Contact Phone: {contactPhone}\n Contact Email: {contactEmail}\n";
        }

        public void Input(string storeName, string address, string storeProfile, string contactPhone, string contactEmail)
        {
            this.storeName = storeName;
            this.address = address;
            this.storeProfile = storeProfile;
            this.contactPhone = contactPhone;
            this.contactEmail = contactEmail;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
