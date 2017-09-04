using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hangtur;

namespace HangturTest
{
    [TestClass]
    public class HangturTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestException1()
        {
            GameLogic h = new GameLogic("");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestException2()
        {
            GameLogic h = new GameLogic(new string('-', 174));
        }

        [TestMethod]
        public void TestSuccess()
        {
            String word = "asdf";
            String guess = "____";
            GameLogic gl = new GameLogic(word);

            Assert.AreEqual(guess, gl.CurrentGuess);

            Assert.AreEqual('C', gl.Letters[2]);

            gl.Guess('c');

            Assert.AreEqual('_', gl.Letters[2]);

            Assert.AreEqual(guess, gl.CurrentGuess);

            Assert.AreEqual('A', gl.Letters[0]);

            gl.Guess('a');

            Assert.AreEqual('_', gl.Letters[0]);

            Assert.AreEqual("A___", gl.CurrentGuess);

            Assert.AreEqual('F', gl.Letters[5]);

            gl.Guess('F');

            Assert.AreEqual('_', gl.Letters[5]);

            Assert.AreEqual("A__F", gl.CurrentGuess);

            Assert.IsFalse(gl.Attempt("aSgf"));

            Assert.IsTrue(gl.Attempt("aSdf"));

            gl.Guess('4');
        }

        [TestMethod]
        public void TestFail()
        {
            String word = "asdf";
            String guess = "____";
            GameLogic gl = new GameLogic(word);

            Assert.AreEqual(guess, gl.CurrentGuess);
            Assert.AreEqual(0, gl.Fails);

            gl.Guess('e');
            Assert.AreEqual(1, gl.Fails);
            Assert.AreEqual(guess, gl.CurrentGuess);
            gl.Guess('W');
            Assert.AreEqual(2, gl.Fails);
            Assert.AreEqual(guess, gl.CurrentGuess);
            gl.Guess('7');
            Assert.AreEqual(3, gl.Fails);
            Assert.AreEqual(guess, gl.CurrentGuess);
            gl.Guess('e');
            Assert.AreEqual(4, gl.Fails);
            Assert.AreEqual(guess, gl.CurrentGuess);
            guess = "A___";
            gl.Guess('a');
            Assert.AreEqual(4, gl.Fails);
            Assert.AreEqual(guess, gl.CurrentGuess);
            gl.Guess('k');
            Assert.AreEqual(5, gl.Fails);
            Assert.AreEqual(guess, gl.CurrentGuess);
            gl.Guess('P');
            Assert.AreEqual(6, gl.Fails);
            Assert.AreEqual(guess, gl.CurrentGuess);
            gl.Guess('Å');
            Assert.AreEqual(6, gl.Fails);
            Assert.AreEqual(guess, gl.CurrentGuess);

            Assert.IsFalse(gl.Attempt("ASDF"));
        }
    }
}
