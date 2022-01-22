export class baseComponent {
  constructor() {}
  public getVariableName(name: any) {
    return name.toString().match(/[.](\w+)/)[1]; 
  }
}
