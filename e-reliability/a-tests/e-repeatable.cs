[TestMethod]
[DataRow("email@valido.com", "email@balta.io")]
public void ShouldValidateEmail(string email)
{
    Assert.IsTrue(new Email(email).IsValid());
}