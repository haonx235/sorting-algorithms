using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Sorting_Algorithms
{
    public partial class MainForm : Form
    {
        //cb = comboBox
        //tb = TextBox
        //gb = groupBox
        //bt = button
        //lb = label
        //rb = radioButton
        //ms = menuStrip

        //Khai báo biến
        Random rand = new Random();
        List<int> result;
        HashSet<int> check = new HashSet<int>();
        public static Int32 i; //biến đếm

        //Khối hàm chức năng riêng

        public int GenerateRandomNumber(int min, int max)
        {
            Random ran = new Random();
            return ran.Next(min, max);
        }

        public int CountNumberOfWords(string s) //Ví dụ: abc def có 2 từ
        {
            int number_of_words = 1, m = 0;
            //Hàm đếm số từ trong chuỗi
            s = s.Trim(); //Xóa các khoảng trắng vô nghĩa 2 đầu
            if (s == null)
                number_of_words = 0;
            else
            {
                for (m = 1; m < s.Length; m++)
                {
                    if ((s[m] == ' ') && (s[m - 1] != ' '))
                        number_of_words++;
                }
            }
            return number_of_words;
        }

        public int GetNumberByPosition(string s, int pos) //Hàm lấy số từ dãy
        {
            string temp = "";
            int j, k = 0, l = 0; //j: biến đếm, k: vị trí đếm, l: độ dài từ
            int number_of_words = CountNumberOfWords(s);

            //Hàm lấy từng phần tử
            s = s.Trim();
            if (pos == 0)
            {
                for (l = 0; s[k + l] != ' '; l++) ;
            }
            else if (pos == number_of_words - 1)
            {
                for (l = 0, k = s.Length - 1; s[k] != ' '; k--, l++) ;
                k++;
            }
            else
            {
                for (j = 0; j < pos; j++)
                {
                    for (; s[k] != ' '; k++) ;
                    while (s[k] == ' ')
                        k++;
                    for (l = 1; s[k + l - 1] != ' '; l++) ;
                }
            }
            temp = s.Substring(k, l);
            return int.Parse(temp);
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void lbSelection_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void tbChanged_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void msHelp_Click(object sender, EventArgs e)
        {

        }

        private void btBrowse_Click(object sender, EventArgs e)
        {
            if(tbResult.Text != "")
                MessageBox.Show("Vui lòng nhấn 'Khôi phục mặc định' trước khi khởi tạo từ tệp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                result = new List<int>();
                Stream myStream;
                OpenFileDialog open = new OpenFileDialog();
                string file_text = "";
                string file_name = "";
                if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if((myStream = open.OpenFile()) != null)
                    {
                        file_name = open.FileName;
                        file_text = File.ReadAllText(file_name);
                    }
                }

                //Khởi tạo từ tệp
                if (file_name == "")
                    return;
                else
                {
                    for (int i = 0; i < CountNumberOfWords(file_text); i++)
                    {
                        int validity = 1;
                        for (int j = 0; j < file_text.Length; j++)
                        {
                            int output = 0;
                            if (file_text[j] == ' ') ;
                            else if (!(int.TryParse(file_text[j].ToString(), out output)))
                            {
                                MessageBox.Show("Dãy nhập vào chứa ký tự không hợp lệ!\r\nVui lòng nhập lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                validity = 0;
                                break;
                            }
                        }
                        if (validity == 1)
                        {
                            tbResult.Text = file_text;
                            result.Add(GetNumberByPosition(tbResult.Text, i));
                        }
                        else break;
                    }
                }
            }
            
        }

        private void cbSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSelection.Text == "Interchange sort (Đổi chỗ trực tiếp)")
                tbIdea.Text = "Thuật toán Interchange sort sẽ duyệt qua tất cả các cặp giá trị trong mảng và hoán vị hai giá trị trong một cặp nếu cặp giá trị đó là nghịch thế.";
            else if (cbSelection.Text == "Bubble sort (Sắp xếp nổi bọt)")
                tbIdea.Text = "Tư tưởng của thuật toán Bubble sort là nhẹ nổi lên và nặng chìm xuống. \r\nKhái niệm nặng nhẹ là khái niệm trừu tượng.";
            else if (cbSelection.Text == "Selection sort (Sắp xếp chọn trực tiếp)")
                tbIdea.Text = "Bước 0: Tìm vị trí giá trị nhỏ nhất trong phạm vi [0,n-1] và hoán vị giá trị tại vị trí này và phần tử a[0].\r\n Bước 1: Tìm vị trí giá trị nhỏ nhất trong phạm vi [1,n-1] và hoán vị giá trị tại vị trí này và phần tử a[1].";
            else if (cbSelection.Text == "Heap sort (Sắp xếp vun đống)")
                tbIdea.Text = "Bước 1: – Xây dựng Heap: Sử dụng thao tác Heapify để chuyển đổi một mảng bình thường thành Heap. \r\nBước 2 – Sắp xếp. \r\n+ Hoán vị phần tử cuối cùng của Heap với phần tử đầu tiên của Heap. \r\n+ Loại bỏ phần tử cuối cùng.\r\n + Thực hiện thao tác Heapify để điều chỉnh phần tử đầu tiên.";
            else if (cbSelection.Text == "Merge sort (Sắp xếp trộn)")
                tbIdea.Text = "Thuật toán Merge Sort chia không gian cần sắp xếp thành 2 không gian con.\r\n+ Nếu không gian con thứ nhất có nhiều hơn một phần tử thì sắp xếp không gian con này bằng thuật toán Merge Sort.\r\n + Nếu không gian con thứ hai có nhiều hơn một phần tử thì sắp xếp không gian con này bằng thuật toán Merge Sort.\r\n + Trộn 2 không gian con đã được sắp xếp lại với nhau.";
            else if (cbSelection.Text == "Quick sort (Sắp xếp nhanh)")
                tbIdea.Text = "Thuật toán quick sort chia không gian cần sắp xếp thành 2 không gian con là không gian con 1 và không gian con 2. Không gian con 1 là không gian mà tất cả các phần tử thuộc không gian này đều nhỏ hơn tất cả các phần tử thuộc không gian con 2. \r\n+ Nếu không gian con thứ nhất có nhiều hơn một phần tử thì sắp xếp không gian con này bằng thuật toán Quick Sort. \r\n+ Nếu không gian con thứ hai có nhiều hơn một phần tử thì sắp xếp không gian con này bằng thuật toán Quick Sort.";
            else if (cbSelection.Text == "Insertion sort (Sắp xếp chèn)")
                tbIdea.Text = "Thuật toán Insertion sort sắp xếp dựa trên tư tưởng là không gian cần sắp xếp đã được sắp xếp một phần và ta chỉ cần thêm một giá trị mới vào không gian này sao cho không gian mới được sắp xếp mà thôi.";

            if (cbSelection.Text == "Interchange sort (Đổi chỗ trực tiếp)")
                tbProgram.Text = "for (i = 0; i <= n - 2; i++)\r\n{\r\n\tfor (int j = i + 1; j <= n - 1; j++)\r\n\t\tif (a[i] > a[j])\r\n\t\t{\r\n\t\t\tint temp = a[i];\r\n\t\t\ta[i] = a[j];\r\n\t\t\ta[j] = temp;\r\n\t\t}\r\n}";
            else if (cbSelection.Text == "Bubble sort (Sắp xếp nổi bọt)")
                tbProgram.Text = "for (i = 0; i <= n - 2; i++)\r\n{\r\n\tfor (int j = n - 1; j >= i + 1; j--)\r\n\t\tif (a[j] < a[j - 1])\r\n\t\t{\r\n\t\t\tint temp = a[j];\r\n\t\t\ta[j] = a[j - 1];\r\n\t\t\ta[j - 1] = temp;\r\n\t\t}\r\n}";
            else if (cbSelection.Text == "Selection sort (Sắp xếp chọn trực tiếp)")
                tbProgram.Text = "for (i = 0; i <= n - 2; i++)\r\n{\r\n\tint min = i;\r\n\tfor (int j = i; j <= n - 1; j++)\r\n\t\tif (a[j] < a[min])\r\n\t\t\tmin = j;\r\n\tint temp = a[i];\r\n\ta[i] = a[min];\r\n\ta[min] = temp;\r\n}";
            else if (cbSelection.Text == "Heap sort (Sắp xếp vun đống)")
            {
                tbProgram.Text = "void Heapify(int a[], int n, int pos)\r\n{\r\n\twhile (pos <= n/2 - 1)\r\n\t{\r\n\t\tint child1 = 2 * pos + 1;\r\n\t\tint child2 = 2 * pos + 2;\r\n\t\tint sen = child1; //đặt lính canh sen = sentinel\r\n\t\tif (child2 < n && a[sen] < a[child2])\r\n\t\t\tsen = child2;\r\n\t\tif (a[pos] < a[sen])\r\n\t\t{\r\n\t\t\tint temp = a[pos];\r\n\t\t\ta[pos] = a[sen];\r\n\t\t\ta[sen] = temp;\r\n\t\t}\r\n\t\tpos = sen;\r\n\t}\r\n}";
                tbProgram.Text += "\r\n\r\nvoid BuildHeap(int a[], int n)\r\n{\r\n\tfor (int i = n / 2 - 1; i >= 0; i--)\r\n\t\tHeapify(a, n, i);\r\n}";
                tbProgram.Text += "\r\n\r\nvoid HeapSort(int a[], int n)\r\n{\r\n\tint i = 1; //Biến đếm\r\n\tBuildHeap(a, n);\r\n\tfor (int length = n; length > 1; i++)\r\n\t{\r\n\t\tint temp = a[0];\r\n\t\ta[0] = a[length - 1];\r\n\t\ta[length - 1] = temp;\r\n\t\tlength--;\r\n\t\tHeapify(a, length, 0);\r\n\t}\r\n}";
                tbProgram.Text += "\r\n\r\nint main()\r\n{\r\n\tint a[];\r\n\tint n;\r\n\tHeapSort(a, n);\r\n}";
            }
            else if (cbSelection.Text == "Merge sort (Sắp xếp trộn)")
            {
                tbProgram.Text = "void Merge(int a[], int Left, int Mid, int Right)\r\n{\r\n\tint temp[100];\r\n\tint n;\r\n\tint i = Left;\r\n\tint j = Mid + 1;\r\n\tn = 0;\r\n\twhile (!(i > Mid && j > Right))\r\n\t{\r\n\t\tif ((i <= Mid && j <= Right && a[i] < a[j]) || (j > Right))\r\n\t\t\ttemp[n++] = a[i++];\r\n\t\telse\r\n\t\t\ttemp[n++] = a[j++];\r\n\t}\r\n\tfor (int k = 0; k < n; k++)\r\n\t\ta[Left + k] = temp[k];\r\n}";
                tbProgram.Text += "\r\n\r\nvoid MergeSort(int a[], int Left, int Right)\r\n{\r\n\tif (Left < Right)\r\n\t{\r\n\t\tint Mid = (Left + Right) / 2;\r\n\t\tMergeSort(a, Left, Mid);\r\n\t\tMergeSort(a, Mid + 1, Right);\r\n\t\tMerge(a, Left, Mid, Right);\r\n\t}\r\n}";
                tbProgram.Text += "\r\n\r\nint main()\r\n{\r\n\tint a[];\r\n\tint n;\r\n\tMergeSort(a, 0, n - 1);\r\n}";
            }
            else if (cbSelection.Text == "Quick sort (Sắp xếp nhanh)")
            {
                tbProgram.Text = "void Partition(int a[], int Left, int Right, int &m1, int &m2)\r\n{\r\n\tint pivot = a[(Left + Right)/2];\r\n\tint low = Left;\r\n\tint high = Right;\r\n\twhile (low < high)\r\n\t{\r\n\t\twhile (a[low] < pivot)\r\n\t\t\tlow++;\r\n\t\twhile (a[high] > pivot)\r\n\t\t\thigh--;\r\n\t\tif (low <= high)\r\n\t\t{\r\n\t\t\tint temp = a[low];\r\n\t\t\ta[low] = a[high];\r\n\t\t\ta[high] = temp;\r\n\t\t\tlow++;\r\n\t\t\thigh--;\r\n\t\t}\r\n\t}\r\n\tm1 = high;\r\n\tm2 = low;\r\n}";
                tbProgram.Text += "\r\n\r\nvoid QuickSort(int a, int Left, int Right)\r\n{\r\n\tif (Left < Right)\r\n\t{\r\n\t\tint m1 = 0, m2 = 0;\r\n\t\tPartition(a, Left, Right, ref m1, ref m2);\r\n\t\tQuickSort(a, Left, m1);\r\n\t\tQuickSort(a, m2, Right);\r\n\t}\r\n}";
                tbProgram.Text += "\r\n\r\nint main()\r\n{\r\n\tint a[];\r\n\tint n;\r\n\tQuickSort(a, 0, n - 1);\r\n}";
            }
            else if (cbSelection.Text == "Insertion sort (Sắp xếp chèn)")
                tbProgram.Text = "for (int i = 1; i <= n - 1; i++)\r\n{\r\n\tint j;\r\n\tint x = result[i];\r\n\tfor (j = i - 1; j >= 0 && result[j] > x; j--)\r\n\t\ta[j + 1] = a[j];\r\n\ta[j + 1] = x;\r\n}";  
        }

        private void gbProgram_Enter(object sender, EventArgs e)
        {

        }

        public void btGenerate_Click(object sender, EventArgs e)
        {
            tbResult.Text = null;
            result = new List<int>();

            if (rbRandomize.Checked == false && rbFromKeyboard.Checked == false && rbFromFile.Checked == false)
                MessageBox.Show("Phương thức khởi tạo chưa được chọn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {

                //Khởi tạo ngẫu nhiên
                if (rbRandomize.Checked == true)
                {
                    if (tbNumberOfElements.Text == "")
                        MessageBox.Show("Số phần tử cần khởi tạo chưa được nhập!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                    {
                        if (int.Parse(tbNumberOfElements.Text) > 30)
                            MessageBox.Show("Số phần tử phải nhỏ hơn hoặc bằng 30!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        else
                        {
                            //Khởi tạo số ngẫu nhiên gán vô mảng giá trị result
                            for (i = 0; i < int.Parse(tbNumberOfElements.Text); i++)
                            {
                                int curValue = rand.Next(-200, 200);
                                while (check.Contains(curValue))
                                {
                                    curValue = rand.Next(1, 100);
                                }
                                result.Add(curValue);
                                check.Add(curValue);
                                tbResult.Text = tbResult.Text + result[i].ToString() + " " + " ";
                            }
                        }
                    }
                }

                //Khởi tạo từ bàn phím
                if (rbFromKeyboard.Checked == true)
                {
                    if (tbInput.Text == "")
                    {
                        MessageBox.Show("Dãy số cần sắp xếp chưa được nhập!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        for (int i = 0; i < CountNumberOfWords(tbInput.Text); i++)
                        {
                            int validity = 1;
                            for (int j = 0; j < tbInput.Text.Length; j++)
                            {
                                int output = 0;

                                if (tbInput.Text[j] == ' ') ;     //Nếu là dấu cách thì bỏ qua
                                else if (!(int.TryParse(tbInput.Text[j].ToString(), out output)))   //Nếu không chuyển từ chuỗi sang số được thì báo lỗi
                                {
                                    MessageBox.Show("Dãy nhập vào không hợp lệ!\r\nVui lòng nhập lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    validity = 0;
                                    break;
                                }
                            }
                            if (validity == 1)
                            {
                                result.Add(GetNumberByPosition(tbInput.Text, i));
                                tbResult.Text = tbResult.Text + result[i].ToString() + " " + " ";
                            }
                            else break;
                        }
                    }
                }
            }
        }

        private void lbBrowse_Click(object sender, EventArgs e)
        {

        }

        private void rbTypeOfGeneration_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFromFile.Checked == true)
            {
                lbNumberOfElements.Enabled = false;
                tbNumberOfElements.Enabled = false;
                lbInput.Enabled = false;
                tbInput.Enabled = false;
                lbBrowse.Enabled = true;
                btBrowse.Enabled = true;
                btGenerate.Enabled = false;
            }
            else if (rbFromKeyboard.Checked == true)
            {
                lbNumberOfElements.Enabled = false;
                tbNumberOfElements.Enabled = false;
                lbInput.Enabled = true;
                tbInput.Enabled = true;
                lbBrowse.Enabled = false;
                btBrowse.Enabled = false;
                btGenerate.Enabled = true;
            }
            else if (rbRandomize.Checked == true)
            {
                lbNumberOfElements.Enabled = true;
                tbNumberOfElements.Enabled = true;
                lbInput.Enabled = false;
                tbInput.Enabled = false;
                lbBrowse.Enabled = false;
                btBrowse.Enabled = false;
                btGenerate.Enabled = true;
            }
        }

        private void tbResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void btRun_Click(object sender, EventArgs e)
        {
            //Sắp xếp và in ra màn hình
            if (cbSelection.Text == "")
            {
                MessageBox.Show("Phương thức sắp xếp chưa được chọn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (tbResult.Text == "")
            {
                MessageBox.Show("Dãy số cần sắp xếp chưa được khởi tạo!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //Xác định số phần tử cần sắp xếp
            int number_of_elements = 0;
            if (rbRandomize.Checked == true)
                number_of_elements = int.Parse(tbNumberOfElements.Text);
            else if (rbFromKeyboard.Checked == true)
                number_of_elements = CountNumberOfWords(tbInput.Text);
            else if (rbFromFile.Checked == true)
                number_of_elements = CountNumberOfWords(tbResult.Text);

            if (cbSelection.Text == "Interchange sort (Đổi chỗ trực tiếp)")
            {
                string stepformat = "\r\r\nBước {0, 2}: ";
                for (i = 0; i <= (number_of_elements - 2); i++)
                {
                    tbResult.Text += System.String.Format(stepformat, i + 1);
                    for (int j = i + 1; j <= (number_of_elements - 1); j++)
                    {
                        if (result[i] > result[j])
                        {
                            int temp = result[i];
                            result[i] = result[j];
                            result[j] = temp;
                        }
                    }
                    for (int k = 0; k < number_of_elements; k++)
                        tbResult.Text += result[k] + " " + " ";
                }
                tbResult.Text += "\r\nSắp xếp tăng: ";
                for (int k = 0; k <= number_of_elements - 1; k++)
                    tbResult.Text += result[k] + " " + " ";
                tbResult.Text += "\r\nSắp xếp giảm: ";
                for (int k = number_of_elements - 1; k >= 0; k--)
                    tbResult.Text += result[k] + " " + " ";
            }

            if (cbSelection.Text == "Bubble sort (Sắp xếp nổi bọt)")
            {
                string stepformat = "\r\r\nBước {0, 2}: ";
                for (i = 0; i <= (number_of_elements - 2); i++)
                {
                    tbResult.Text += System.String.Format(stepformat, i + 1);
                    for (int j = (number_of_elements - 1); j >= i + 1; j--)
                        if (result[j] < result[j - 1])
                        {
                            int temp = result[j];
                            result[j] = result[j - 1];
                            result[j - 1] = temp;
                        }
                    for (int k = 0; k < number_of_elements; k++)
                        tbResult.Text += result[k] + " " + " ";
                }
                tbResult.Text += "\r\nSắp xếp tăng: ";
                for (int k = 0; k <= number_of_elements - 1; k++)
                    tbResult.Text += result[k] + " " + " ";
                tbResult.Text += "\r\nSắp xếp giảm: ";
                for (int k = number_of_elements - 1; k >= 0; k--)
                    tbResult.Text += result[k] + " " + " ";
            }

            if (cbSelection.Text == "Selection sort (Sắp xếp chọn trực tiếp)")
            {
                string stepformat = "\r\r\nBước {0, 2}: ";
                for (i = 0; i <= (number_of_elements - 2); i++)
                {
                    int min = i;
                    tbResult.Text += System.String.Format(stepformat, i + 1);
                    for (int j = i; j <= (number_of_elements - 1); j++)
                        if (result[j] < result[min])
                            min = j;
                    int temp = result[i];
                    result[i] = result[min];
                    result[min] = temp;
                    for (int k = 0; k < number_of_elements; k++)
                        tbResult.Text += result[k] + " " + " ";
                }
                tbResult.Text += "\r\nSắp xếp tăng: ";
                for (int k = 0; k <= number_of_elements - 1; k++)
                    tbResult.Text += result[k] + " " + " ";
                tbResult.Text += "\r\nSắp xếp giảm: ";
                for (int k = number_of_elements - 1; k >= 0; k--)
                    tbResult.Text += result[k] + " " + " ";
            }

            if (cbSelection.Text == "Heap sort (Sắp xếp vun đống)")
            {
                HeapSort(result, number_of_elements);
                tbResult.Text += "\r\nSắp xếp tăng: ";
                for (int k = 0; k <= number_of_elements - 1; k++)
                    tbResult.Text += result[k] + " " + " ";
                tbResult.Text += "\r\nSắp xếp giảm: ";
                for (int k = number_of_elements - 1; k >= 0; k--)
                    tbResult.Text += result[k] + " " + " ";
            }

            if (cbSelection.Text == "Merge sort (Sắp xếp trộn)")
            {
                MergeSort(result, 0, number_of_elements - 1);
                tbResult.Text += "\r\nSắp xếp tăng: ";
                for (int k = 0; k <= number_of_elements - 1; k++)
                    tbResult.Text += result[k] + " " + " ";
                tbResult.Text += "\r\nSắp xếp giảm: ";
                for (int k = number_of_elements - 1; k >= 0; k--)
                    tbResult.Text += result[k] + " " + " ";
            }

            if (cbSelection.Text == "Quick sort (Sắp xếp nhanh)")
            {
                QuickSort(result, 0, number_of_elements - 1);
                tbResult.Text += "\r\nSắp xếp tăng: ";
                for (int k = 0; k <= number_of_elements - 1; k++)
                    tbResult.Text += result[k] + " " + " ";
                tbResult.Text += "\r\nSắp xếp giảm: ";
                for (int k = number_of_elements - 1; k >= 0; k--)
                    tbResult.Text += result[k] + " " + " ";
            }

            if (cbSelection.Text == "Insertion sort (Sắp xếp chèn)")
            {
                string stepformat = "\r\r\nBước {0, 2}: ";
                for (int i = 1; i <= number_of_elements - 1; i++)
                {
                    int j;
                    tbResult.Text += System.String.Format(stepformat, i);
                    int x = result[i];
                    for (j = i - 1; j >= 0 && result[j] > x; j--)
                        result[j + 1] = result[j];
                    result[j + 1] = x;
                    for (int k = 0; k <= number_of_elements - 1; k++)
                        tbResult.Text += result[k] + " " + " ";
                }
                tbResult.Text += "\r\nSắp xếp tăng: ";
                for (int k = 0; k <= number_of_elements - 1; k++)
                    tbResult.Text += result[k] + " " + " ";
                tbResult.Text += "\r\nSắp xếp giảm: ";
                for (int k = number_of_elements - 1; k >= 0; k--)
                    tbResult.Text += result[k] + " " + " ";
            }
        }

        private void btRestoreToDefault_Click(object sender, EventArgs e)
        {
            tbResult.Text = null;
            tbInput.Text = null;
            cbSelection.Text = null;
        }

        private void gbGenerate_Enter(object sender, EventArgs e)
        {

        }

        //Khối hàm sắp xếp
        //Heap sort
        public void Heapify(List<int> a, int n, int pos)
        {
            while (pos <= n/2 - 1)
            {
                int child1 = 2*pos+1;
                int child2 = 2*pos+2;
                int sen = child1; //đặt lính canh sen = sentinel
                if (child2 < n && a[sen] < a[child2])
                    sen = child2;
                if (a[pos] < a[sen])
                {
                    int temp = a[pos];
                    a[pos] = a[sen];
                    a[sen] = temp;
                }
                pos = sen;
            }
        }
        public void BuildHeap(List<int> a, int n)
        {
            for (int i = n / 2 - 1; i >= 0; i--)
                Heapify(a, n, i);
        }
        public void HeapSort(List<int> a, int n)
        {
            int r = 1; //Biến đếm
            string stepformat = "\r\r\nBước {0, 2}: ";
            BuildHeap(a, n);
            for (int length = n; length > 1; r++)
            {
                int temp = a[0];
                a[0] = a[length - 1];
                a[length - 1] = temp;
                tbResult.Text += System.String.Format(stepformat, r);
                length--;
                Heapify(a, length, 0);
                for (int k = 0; k < n; k++)
                    tbResult.Text += result[k] + " " + " ";
            }
        }

        //Merge sort
        public void Merge(List<int> a, int Left, int Mid, int Right)
        {
            int []temp = new int[100];
            int n;
            int r = Left;
            int s = Mid + 1;
            n = 0;
            while (!(r > Mid && s > Right))
            {
                if ((r <= Mid && s <= Right && a[r] < a[s]) || (s > Right))
                    temp[n++] = a[r++];
                else
                    temp[n++] = a[s++];
            }
            for (int i = 0; i < n; i++)
                a[Left + i] = temp[i];
        }
        public void MergeSort(List<int> a, int Left, int Right)
        {
            if (Left < Right)
            {
                int Mid = (Left + Right) / 2;
                MergeSort(a, Left, Mid);
                MergeSort(a, Mid + 1, Right);
                Merge(a, Left, Mid, Right);
            }
        }

        //Quick sort
        public void Partition(List<int> a, int Left, int Right, ref int m1, ref int m2)
        {
            int pivot = a[(Left + Right)/2];
            int low = Left;
            int high = Right;
            while (low < high)
            {
                while (a[low] < pivot)
                    low++;
                while (a[high] > pivot)
                    high--;
                if (low <= high)
                {
                    int temp = a[low];
                    a[low] = a[high];
                    a[high] = temp;
                    low++;
                    high--;
                }
            }
            m1 = high;
            m2 = low;
        }
        public void QuickSort(List<int> a, int Left, int Right)
        {
            if (Left < Right)
            {
                int m1 = 0, m2 = 0;
                Partition(a, Left, Right, ref m1, ref m2);
                QuickSort(a, Left, m1);
                QuickSort(a, m2, Right);
            }
        }

        private void msAbout_Click(object sender, EventArgs e)
        {
            About a = new About();
            a.Show();
        }

        private void msGuide_Click(object sender, EventArgs e)
        {
            Help b = new Help();
            b.Show();
        }
    }
}
