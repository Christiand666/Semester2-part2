using System;

using NUnit.Framework;
using UnitTestProject2;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class ReservationTets
    {
        [Test]
        public void CanBecancelledBy_UserIsAdmin_ReturnsTrue()
        {
            //arrange
            var reservation = new Reservation();


            //act

            var result = reservation.CanBeCancelledBy(new User { IsAdmin = true });

            //assert
            //Assert.IsTrue(result);
            //anden måde at skrive assert på

            Assert.That(result, Is.True);

            // endnu en måde
            //Assert.That(result == true);


        }
        [Test]
        public void CanBeCancelledBy_SameUserCancellingTheReservation_ReturnTrue()
        {
            var user = new User();
            var reservation = new Reservation { MadeBy = user };

            var result = reservation.CanBeCancelledBy(user);

            Assert.IsTrue(result);
        }
        [Test]
        public void CanBeCancelledBy_anotherUserCancellingReservation_ReturnFalse()
        {
            var reservation = new Reservation();

            var result = reservation.CanBeCancelledBy(new User());

            Assert.IsFalse(result); 
        }
    }
}
