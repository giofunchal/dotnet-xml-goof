using System.Web.Mvc;
public class Foo {
  public string main() {
     return "foo";
  }

  [ValidateInput(false)]
  public ActionResult ControllerMethod(string input) {
     return "foo";
  }
}
