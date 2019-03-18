using RockPaperScissor.Business.Interfaces;
using System;
using System.Linq;
using System.Web.UI;

public partial class _Default : System.Web.UI.Page, IGetUserInput
{
    /// <summary>
    /// Page Load.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Page_Load(object sender, EventArgs e)
    {

   
        if (!Page.IsPostBack)
        {
         
        }
    }


    int userScore = 0;
    int comScore = 0;

    public string ShowResult(int flagNum)
    {
        int userScore;
        int comScore;
        int totalScore;
        if (ViewState["userount"] != null)
        {
            userScore = Convert.ToInt32(ViewState["userount"]);
        }
        else
        {
            userScore = 0;
        }

        if (ViewState["Count"] != null)
        {
            comScore = Convert.ToInt32(ViewState["Count"]);
        }
        else
        {
            comScore = 0;
        }

        if (ViewState["TotalScore"] != null)
        {
            totalScore = Convert.ToInt32(ViewState["TotalScore"]);
        }
        else
        {
            totalScore = 0;
        }
        string result = string.Empty;
        switch (flagNum)
        {
            case 1:
                result = "User Win !!";
                userScore++;
                ViewState["userount"] = userScore;
                totalScore++;
                ViewState["TotalScore"] = totalScore;
                break;
            case 2:
                result = "Computer Win !!";
                comScore++;
                ViewState["Count"] = comScore;
                totalScore++;
                ViewState["TotalScore"] = totalScore;
                break;
            case 3:
                result = "Draw !!";
                break;
            default:
                break;
        }
        return result;

    }

    /// <summary>
    /// Method will matches with user input request.
    /// </summary>
    public void MatchSelection()
    {
        Random rnd = new Random(DateTime.Now.Millisecond);
        int comChoice;
        comChoice = rnd.Next(1, 4);


        int flagNum = 0;
        
        //Compuer Choice
        switch (comChoice)
        {
            case 1:

                Label1.Text = "Computer Selected ROCK";
                if (RadioButton1.Checked)
                {
                    flagNum = 3;
                }
                else if (RadioButton2.Checked)
                {
                    flagNum = 1;
                  

                }
                else if (RadioButton3.Checked)
                {
                    flagNum = 2;
               
                }
                break;
            case 2:
                Label1.Text = "Computer Selected PAPER";

                if (RadioButton1.Checked)
                {
                    flagNum = 2;


                }
                else if (RadioButton2.Checked)
                {
                    flagNum = 3;

                }
                else if (RadioButton3.Checked)
                {
                    flagNum = 1;
                }
                break;
            case 3:
                Label1.Text = "Computer Selected SCISSOR";

                if (RadioButton1.Checked)
                {
                    flagNum = 1;
             
                }
                else if (RadioButton2.Checked)
                {
                    flagNum = 2;
                

                }
                else if (RadioButton3.Checked)
                {
                    flagNum = 3;
                }
                break;
            default:
                Console.WriteLine("Error");
                break;
        }
        string result = ShowResult(flagNum);
        Label2.Text = result;
    }

    /// <summary>
    /// Display the Final Result.
    /// </summary>
    public string DisplayResult()
    {
        lblresult.Visible = false;
        int userCount = ViewState["userount"] != null ? Convert.ToInt32(ViewState["userount"]) : 0;
        int computerCount = ViewState["Count"] != null ? Convert.ToInt32(ViewState["Count"]) : 0;
        lblComScoreText.Visible = true;
        lblUserScoreTxt.Visible = true;
        lblComScoreText.Visible = true;
        lblComputer.Visible = true;
        lblUserScore.Visible = true;
        lblUserScore.Text = userCount.ToString();
        lblComputer.Text = computerCount.ToString();
        string result = string.Empty;
        if (ViewState["TotalScore"] != null)
        {
            if (Convert.ToUInt32(ViewState["TotalScore"]) == 3)
            {
                lblresult.Visible = true;
                if (userCount > computerCount)
                {
                   
                    result= "Final Winner is User";
                }
                else if (computerCount > userCount)
                {
                   
                    result= "Final Winner is Computer";
                }
                if (new[] { userCount, computerCount }.All(x => x == 0))
                {
                   
                    result = "Draw the Game";
                }

                //Label5.Text = "";
                RadioButton3.Checked = false;
                RadioButton2.Checked = false;
                RadioButton1.Checked = false;
                ViewState["TotalScore"] = 0;
                ViewState["userount"] = 0;
                ViewState["Count"] = 0;
            }

        }
        return result;
    }

    /// <summary>
    /// Start Button Click
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void StartGame_Click(object sender, EventArgs e)
    {

        if(RadioButton1.Checked || RadioButton2.Checked || RadioButton3.Checked)
        {
            MatchSelection();
            Label1.Visible = true;
            Label2.Visible = true;

            lblresult.Text= DisplayResult();
        }
       


    }
}