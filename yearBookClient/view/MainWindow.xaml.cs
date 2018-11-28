using HttpUtils;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using yearBookClient.model;

namespace yearBookClient.view {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        private const String apiEndpoint = "http://localhost:8080/";
        private static RestClient client;
        private static Student studentResponse;
        private static List<Student> studentResponseList;
        private static SchoolClass schoolClassResponse;
        private static List<SchoolClass> schoolClassResponseList;
        private  Action onStudentGetAll = () => {
            client.EndPoint = apiEndpoint+"tanulo";
            StudentResponseList = JsonConvert.DeserializeObject<List<Student>>(client.MakeRequest());
        };
        private  Action<string> onStudentGetOne = (string data) => {
            client.EndPoint = $"{apiEndpoint}tanulo/";
            StudentResponse = JsonConvert.DeserializeObject<Student>(client.MakeRequest(data));
        };
        private  Action onSchoolClassGetAll = () => {
            client.EndPoint = apiEndpoint + "osztaly";
            SchoolClassResponseList = JsonConvert.DeserializeObject<List<SchoolClass>>(client.MakeRequest());
        };
        private Action<string> onSchoolClassGetOne = (String data) => {
            client.EndPoint = $"{apiEndpoint}osztaly/";
            SchoolClassResponse = JsonConvert.DeserializeObject<SchoolClass>(client.MakeRequest(data));
        };

        public MainWindow() {
            InitializeComponent();
            client = new RestClient();
        }


        internal static Student StudentResponse { get => studentResponse; set => studentResponse = value; }
        internal static List<Student> StudentResponseList { get => studentResponseList; set => studentResponseList = value; }
        internal static SchoolClass SchoolClassResponse { get => schoolClassResponse; set => schoolClassResponse = value; }
        public Action OnStudentGetAll { get => onStudentGetAll; set => onStudentGetAll = value; }
        public Action<string> OnStudentGetOne { get => onStudentGetOne; set => onStudentGetOne = value; }
        public Action OnSchoolClassGetAll { get => onSchoolClassGetAll; set => onSchoolClassGetAll = value; }
        internal static List<SchoolClass> SchoolClassResponseList { get => schoolClassResponseList; set => schoolClassResponseList = value; }
        public Action<string> OnSchoolClassGetOne { get => onSchoolClassGetOne; set => onSchoolClassGetOne = value; }
    }
}
