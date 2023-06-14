public delegate void  ButtonClickedHandler();
class Button{
    public event ButtonClickedHandler ButtonClicked;
    ButtonClicked += ()=>{Console.WriteLine("click simulation!");};
    
}