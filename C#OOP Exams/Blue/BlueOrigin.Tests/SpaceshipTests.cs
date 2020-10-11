namespace BlueOrigin.Tests
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class SpaceshipTests
    {
       [Test]
        public void CreateEmptyName()
        {

            Spaceship spaceship = new Spaceship("Hi", 1);

            Astronaut astronaut1 = new Astronaut("Gosho", 25);

            Astronaut astronaut2 = new Astronaut("Gosho2", 23);

            spaceship.Add(astronaut1);

            Assert.That(() => spaceship.Add(astronaut2), Throws.InvalidOperationException.With.Message.EqualTo("Spaceship is full!"));
        }

        [Test]
        public void AddAstronautWhoIsAlredyInSpaceship()
        {
            Spaceship spaceship = new Spaceship("Hi", 3);

            Astronaut astronaut1 = new Astronaut("Gosho", 25);

            spaceship.Add(astronaut1);

            Assert.That(() => spaceship.Add(astronaut1), Throws.InvalidOperationException.With.Message.EqualTo($"Astronaut {astronaut1.Name} is already in!"));
        }

        [Test]
        public void AddAstronautInSpaceship()
        {
            Spaceship spaceship = new Spaceship("Hi", 3);

            Astronaut astronaut1 = new Astronaut("Gosho", 25);

            spaceship.Add(astronaut1);

            Assert.That(spaceship.Count, Is.EqualTo(1));
        }

        [Test]
        public void RemoveAstronautFromSpaceship()
        {
            Spaceship spaceship = new Spaceship("Hi", 3);

            Astronaut astronaut1 = new Astronaut("Gosho", 25);

            Astronaut astronaut2 = new Astronaut("Gosho2", 25);

            Astronaut astronaut3 = new Astronaut("Gosho3", 25);

            spaceship.Add(astronaut1);

            spaceship.Add(astronaut2);

            spaceship.Add(astronaut3);

            spaceship.Remove("Gosho3");

            Assert.That(spaceship.Count, Is.EqualTo(2));
        }

        [Test]
        public void RemoveAstronautFromSpaceshipWhosNotInSpaceship()
        {
            Spaceship spaceship = new Spaceship("Hi", 3);

            Astronaut astronaut1 = new Astronaut("Gosho", 25);

            Astronaut astronaut2 = new Astronaut("Gosho2", 25);

            Astronaut astronaut3 = new Astronaut("Gosho3", 25);

            spaceship.Add(astronaut1);

            spaceship.Add(astronaut2);

            spaceship.Add(astronaut3);

            Assert.That(spaceship.Remove("Gosho4"), Is.EqualTo(false));
        }
    }
}