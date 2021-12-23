public class Foo {
  public string main() {
    return "foo";
  }
  public string bar() {
    return "bar";
  }
  [ValidateInput(false)]
  public ActionResult ControllerMethod(string input) {
  }
}
