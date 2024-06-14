namespace ContactsManagerTest
{
    public class UnitTest1
    { // Add Case
        [Fact]
        public void AddCaseSuccesfully()
        {
            // Arrange
            string Action = "Add";
            List<string[]> Contact = new List<string[]>
        {
            new string[] { "Ali", "1234" },
            new string[] { "Ahmad","12345"},
            new string[] {"Malek","123456" }
        };
            string CName = "Sara";
            string Number = "065050500";

            // Act
            List<string[]> result = ContactsManager.CManager.ContactsManager(Action, Contact, CName, Number);
            // Assert
            Assert.Equal(4, result.Count);
        }


        [Fact]
        public void AddCaseRejected()
        {
            // Arrange
            string Action = "Add";
            List<string[]> Contact = new List<string[]>
        {
            new string[] { "Ali", "1234" },
            new string[] { "Ahmad","12345"},
            new string[] {"Malek","123456" }
        };
            string CName = "Ali";
            string Number = "065050500";

            // Act
            List<string[]> result = ContactsManager.CManager.ContactsManager(Action, Contact, CName, Number);
            // Assert
            Assert.Equal(3, result.Count);
        }


        // Remove Case 
        [Fact]
        public void RemoveCase()
        {
            // Arrange
            string Action = "Delete";
            List<string[]> Contact = new List<string[]>
        {
            new string[] { "Ali", "1234" },
            new string[] { "Ahmad","12345"},
            new string[] {"Malek","123456" }
        };
            string CName = "Malek";
            // Act
            List<string[]> result = ContactsManager.CManager.ContactsManager(Action, Contact, CName);

            // Assert
            Assert.Equal(2, result.Count);
        }


        // ViewAll Case
        [Fact]
        public void ViewAllCase()
        {
            // Arrange
            string Action = "VeiwAll";
            List<string[]> Contact = new List<string[]>
        {
            new string[] { "Ali", "1234" },
            new string[] { "Ahmad","12345"},
            new string[] {"Malek","123456" }
        };
            // Act
            List<string[]> result = ContactsManager.CManager.ContactsManager(Action, Contact);
            // Assert
            Assert.Equal(3, result.Count);
        }
    }
}