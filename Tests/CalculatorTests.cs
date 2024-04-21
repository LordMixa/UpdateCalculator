using NUnit.Framework;
using System.Windows.Forms;

namespace WFACalculator.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        private Form1 calculator;

        [SetUp]
        public void Setup()
        {
            calculator = new Form1();
        }

        [Test]
        public void AdditionTest()
        {
            calculator.textBoxValue.Text = "5";
            calculator.operationFinisher();
            calculator.buttonPlus_Click(null, null);
            calculator.textBoxValue.Text = "10";
            calculator.operationFinisher();
            calculator.buttonEquals_Click(null, null);
            Assert.That(calculator.textBoxResult.Text, Is.EqualTo("15"));
        }

        [Test]
        public void SubtractionTest()
        {
            calculator.textBoxValue.Text = "20";
            calculator.operationFinisher();
            calculator.buttonMinus_Click(null, null);
            calculator.textBoxValue.Text = "7";
            calculator.operationFinisher();
            calculator.buttonEquals_Click(null, null);
            Assert.That(calculator.textBoxResult.Text, Is.EqualTo("13"));
        }

        [Test]
        public void MultiplicationTest()
        {
            calculator.textBoxValue.Text = "4";
            calculator.operationFinisher();
            calculator.buttonMultiply_Click(null, null);
            calculator.textBoxValue.Text = "6";
            calculator.operationFinisher();
            calculator.buttonEquals_Click(null, null);
            Assert.That(calculator.textBoxResult.Text, Is.EqualTo("24"));
        }

        [Test]
        public void DivisionTest()
        {
            calculator.textBoxValue.Text = "50";
            calculator.operationFinisher();
            calculator.buttonDivide_Click(null, null);
            calculator.textBoxValue.Text = "10";
            calculator.operationFinisher();
            calculator.buttonEquals_Click(null, null);
            Assert.That(calculator.textBoxResult.Text, Is.EqualTo("5"));
        }

        [Test]
        public void CEButtonTest()
        {     
            calculator.textBoxValue.Text = "10";
            calculator.buttonDelete_Click(null, null);
            Assert.That(calculator.textBoxValue.Text, Is.EqualTo("1"));
            calculator.buttonDelete_Click(null, null);
            calculator.buttonDelete_Click(null, null);
            calculator.operationFinisher();
            calculator.buttonClear_Click(null, null);
            Assert.That(calculator.textBoxResult.Text, Is.EqualTo("0"));
            Assert.That(calculator.result, Is.EqualTo(0));

        }
        [Test]
        public void NumButtonTest()
        {
            calculator.button1_Click(null, null);
            Assert.That(calculator.textBoxValue.Text, Is.EqualTo("1"));
            calculator.button2_Click(null, null);
            Assert.That(calculator.textBoxValue.Text, Is.EqualTo("12")); 
            calculator.button3_Click(null, null);
            Assert.That(calculator.textBoxValue.Text, Is.EqualTo("123"));
            calculator.button4_Click(null, null);
            Assert.That(calculator.textBoxValue.Text, Is.EqualTo("1234"));
            calculator.button5_Click(null, null);
            Assert.That(calculator.textBoxValue.Text, Is.EqualTo("12345"));
            calculator.button6_Click(null, null);
            Assert.That(calculator.textBoxValue.Text, Is.EqualTo("123456"));
            calculator.button7_Click(null, null);
            Assert.That(calculator.textBoxValue.Text, Is.EqualTo("1234567"));
            calculator.button8_Click(null, null);
            Assert.That(calculator.textBoxValue.Text, Is.EqualTo("12345678"));
            calculator.button9_Click(null, null);
            Assert.That(calculator.textBoxValue.Text, Is.EqualTo("123456789"));
            calculator.buttonDot_Click(null, null);
            Assert.That(calculator.textBoxValue.Text, Is.EqualTo("123456789,"));
            calculator.button0_Click(null, null);
            Assert.That(calculator.textBoxValue.Text, Is.EqualTo("123456789,0"));
        }
        [Test]
        public void ButtonPlusMinus_ClickTest_PositiveToNegative()
        {
            calculator.textBoxValue.Text = "5";
            calculator.buttonPlusMinus_Click(null, null);
            Assert.That(calculator.textBoxValue.Text, Is.EqualTo("-5"));
        }

        [Test]
        public void ButtonPlusMinus_ClickTest_NegativeToPositive()
        {
            calculator.textBoxValue.Text = "-10";
            calculator.buttonPlusMinus_Click(null, null);
            Assert.That(calculator.textBoxValue.Text, Is.EqualTo("10"));
        }

        [Test]
        public void ButtonPercantage_ClickTest()
        {
            calculator.textBoxValue.Text = "50";
            calculator.buttonPercantage_Click(null, null);
            Assert.That(calculator.textBoxValue.Text, Is.EqualTo("0,5"));
        }

        [Test]
        public void ButtonPercantage_ClickTest_EmptyTextBox()
        {
            calculator.textBoxValue.Text = "";
            calculator.buttonPercantage_Click(null, null);
            Assert.That(calculator.textBoxValue.Text, Is.EqualTo(""));
        }

        [Test]
        public void ButtonHistory_ClickTest()
        {
            using (var form = new Form())
            {
                calculator.buttonHistory_Click(null, null);
                Assert.That(() => MessageBox.Show(form, "history"), Throws.Nothing);
            }
        }
    }
}