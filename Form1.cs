using DinnerHelper.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DinnerHelper
{
    public partial class Form1 : Form
    {
        Order[] order;
        public Form1()
        {
            InitializeComponent();
            order = new Order[3];
            order[0] = new SelfOrder();
            order[1] = new DinnerOrder();
            order[2] = new BirthdayOrder();
        }

        private void controlsLeave(object sender, EventArgs e)
        {
            SelfOrder currentOrder = (SelfOrder)order[tabControl1.SelectedIndex];
            currentOrder.OrderTitle = t_ordertitle.Text;
            currentOrder.PhoneNumber = t_phoneNumber.Text;
            currentOrder.NumberOfPeople = (int)num_people.Value;
            currentOrder.OrderDate = dtp_orderDate.Value;
            currentOrder.IsVIP = c_VIP.Checked;
            currentOrder.IsWaterServe = c_Wine.Checked;
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    break;
                case 1:
                    DinnerOrder dinnerOrder = (DinnerOrder)currentOrder;
                    dinnerOrder.IsDirect = c_Decorative.Checked;
                    break;
                case 2:
                    BirthdayOrder birthdayOrder = (BirthdayOrder)currentOrder;
                    if(birthdayOrder.NumberOfPeople < 4 && t_cakeWords.Text.Length > 20)
                    {
                        MessageBox.Show("四人以下为八寸蛋糕，最多只能刻20个字哦");
                        break;
                    }
                    if(birthdayOrder.NumberOfPeople >= 4 && t_cakeWords.Text.Length > 50)
                    {
                        MessageBox.Show("大蛋糕最多只能写50个字哦");
                        break;
                    }
                    birthdayOrder.WordsOnCake = t_cakeWords.Text;
                    break;
            }
            if(num_people.Value > 40)
            {
                MessageBox.Show("人数不能超过40。");
                num_people.Value = 40;
            }
            label_budget.Text = currentOrder.computeBudget().ToString("c");
            checkFields();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel1.Parent = tabControl1.SelectedTab;
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    c_Decorative.Visible = false;
                    label9.Visible = false;
                    t_cakeWords.Visible = false;
                    break;
                case 1:
                    c_Decorative.Visible = true;
                    label9.Visible = false;
                    t_cakeWords.Visible = false;
                    break;
                case 2:
                    c_Decorative.Visible = false;
                    label9.Visible = true;
                    t_cakeWords.Visible = true;
                    break;
            }
            controlsLeave(sender, e);
        }

        private void t_cakeWords_KeyUp(object sender, KeyEventArgs e)
        {
            controlsLeave(sender, e);
        }

        private void checkFields()
        {
            bool flag = true;
            flag &= !t_phoneNumber.Text.Equals("");
            flag &= !t_ordertitle.Text.Equals("");
            flag &= num_people.Value != 0;
            flag &= num_people.Value <= 40;
            btn_submit.Enabled = flag;
        }

        private void clearInputs()
        {
            t_ordertitle.Text = "";
            t_phoneNumber.Text = "";
            num_people.Value = 0;
            c_Decorative.Checked = false;
            c_VIP.Checked = false;
            c_Wine.Checked = false;
            t_cakeWords.Text = "";
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            String messageText = "";
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    messageText = string.Format(
                        "请确认订单信息:\n客户姓名：{0}\n联系电话：{1}\n用餐人数：{2}\n用餐日期：{3}\n{4}\n{5}\n费用预算：{6}",
                        order[0].OrderTitle,
                        order[0].PhoneNumber,
                        order[0].NumberOfPeople,
                        order[0].OrderDate,
                        (((SelfOrder)order[0]).IsVIP?"客户是会员":"客户非会员"),
                        (((SelfOrder)order[0]).IsWaterServe?"需要酒水":"不需要酒水"),
                        label_budget.Text);
                    break;
                case 1:
                    messageText = string.Format(
                        "请确认订单信息:\n客户姓名：{0}\n联系电话：{1}\n用餐人数：{2}\n用餐日期：{3}\n{4}\n{5}\n{6}\n费用预算：{7}",
                        order[1].OrderTitle,
                        order[1].PhoneNumber,
                        order[1].NumberOfPeople,
                        order[1].OrderDate,
                        (((SelfOrder)order[1]).IsVIP ? "客户是会员" : "客户非会员"),
                        (((SelfOrder)order[1]).IsWaterServe ? "需要酒水" : "不需要酒水"),
                        (((DinnerOrder)order[1]).IsDirect?"需要华丽装饰":"不需要华丽装饰"),
                        label_budget.Text);
                    break;
                case 2:
                    messageText = string.Format(
                            "请确认订单信息:\n客户姓名：{0}\n联系电话：{1}\n用餐人数：{2}\n用餐日期：{3}\n{4}\n{5}\n蛋糕刻字：\n{6}\n费用预算：{7}",
                            order[2].OrderTitle,
                            order[2].PhoneNumber,
                            order[2].NumberOfPeople,
                            order[2].OrderDate,
                            (((SelfOrder)order[2]).IsVIP ? "客户是会员" : "客户非会员"),
                            (((SelfOrder)order[2]).IsWaterServe ? "需要酒水" : "不需要酒水"),
                            ((BirthdayOrder)order[2]).WordsOnCake,
                            label_budget.Text);
                    break;
            }
            if(MessageBox.Show(messageText, "订单确定", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                MessageBox.Show("订单已提交。");
                clearInputs();
            }
        }
    }
}
