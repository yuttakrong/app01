using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace App01.Facts {
    public class CalculatorFact {

        public class AddMethod : IDisposable {

            private Calculator c;

            private readonly ITestOutputHelper _output;

            // Setup
            public AddMethod(ITestOutputHelper output) {
                _output = output;
                c = new Calculator();
            }

            /*
            [Fact]
            public void OneDigit() {
              // arrange
              //var c = new Calculator();

              // act
              var resut = c.add("1", "1");

              // asset
              Assert.Equal("2", resut);
            }

            [Fact]
            public void OneDigit_2() {
              // arrange
              //var c = new Calculator();

              // act
              var resut = c.add("2", "2");

              // asset
              Assert.Equal("4", resut);
            }
            */

            [Theory]
            [InlineData("1", "1", "2")]
            [InlineData("2", "2", "4")]
            //[MemberData("OneDigitInputs",10)]
            public void OneDigit(string v1, string v2, string expected) {
                // arrange
                //var c = new Calculator();

                // act
                var result = c.add(v1, v2);

                // asset
                _output.WriteLine($"{v1}+{v2} = {result}");

                Assert.Equal(expected, result);
            }

            public static IEnumerable<object[]> OndigitInputs(int count) {
                for (int i = 0; i < count; i++) {
                    yield return new object[] {
            i.ToString(),i.ToString(),i.ToString()
          };
                }
            }

            [Fact]
            public void OneDigit_2() {
                // arrange
                //var c = new Calculator();

                // act
                var resut = c.add("2", "2");

                // asset
                Assert.Equal("4", resut);
            }

            [Fact]
            public void NegativeValues() {
                // arrange
                //var c = new Calculator();

                // act
                var resut = c.add("-5", "8");

                // asset
                Assert.Equal("3", resut);
            }

            [Fact]
            public void EmptyStringOrNull_TreatAsZeor() {
                // arrange
                //var c = new Calculator();

                // act
                var resut1 = c.add(null, "9");
                var resut2 = c.add("", "9");
                var resut3 = c.add("9", null);
                var resut4 = c.add("9", "");

                // asset
                Assert.Equal("9", resut1);
                Assert.Equal("9", resut2);
                Assert.Equal("9", resut3);
                Assert.Equal("9", resut4);
            }

            /*
            [Fact]
            public void TwoDigit() {
              // arrange
              //var c = new Calculator();

              // act
              var resut = c.add("11", "22");

              // asset
              Assert.Equal("33", resut);
            }
            */

            [Fact]
            public void OnlyDigitCharactorIsAllowed() {
                var ex = Assert.Throws<ArgumentException>(() => {
                    c.add("1a", "2b");
                });

                Assert.Equal("value1", ex.ParamName);

            }

            [Fact]
            public void AddTwoDigits() {
                var result = c.add("11", "25");

                Assert.Equal("36", result);
            }

            // Teardown
            public void Dispose() {
                c = null;
                //throw new NotImplementedException();
            }

        }


    }
}
