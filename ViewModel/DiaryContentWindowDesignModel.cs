namespace MyDiary
{
    public class DiaryContentWindowDesignModel : DiaryContentWindowViewModel
    {
        public static DiaryContentWindowDesignModel Instance = new DiaryContentWindowDesignModel();

        public DiaryContentWindowDesignModel()
        {
            Content = "Wahgwan Yo!!";
            isOpen = true;
        }
    }
}
