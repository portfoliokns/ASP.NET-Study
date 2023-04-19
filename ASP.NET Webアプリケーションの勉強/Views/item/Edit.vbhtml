@ModelType ASP.NET_Webアプリケーションの勉強.t_item
@Code
    ViewData("Title") = "Edit"
End Code

<h2>編集ページ</h2>

@Using (Html.BeginForm())
    @Html.AntiForgeryToken()
    
    @<div class="form-horizontal">
        <h4>編集</h4>
        <hr />
        @Html.ValidationSummary(True, "", New With { .class = "text-danger" })
        @Html.HiddenFor(Function(model) model.Id)

        <div class="form-group">
            @ViewBag.japanese.item_name
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.ItemName, New With {.htmlAttributes = New With {.class = "form-control"}})
                @Html.ValidationMessageFor(Function(model) model.ItemName, "", New With {.class = "text-danger"})
            </div>
        </div>

        <div class="form-group">
            @ViewBag.japanese.registration_date
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.RegistrationDate, New With {.htmlAttributes = New With {.class = "form-control"}})
                @Html.ValidationMessageFor(Function(model) model.RegistrationDate, "", New With {.class = "text-danger"})
            </div>
        </div>

        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <input type="submit" value="保存" class="btn btn-default" />
            </div>
        </div>
    </div>
End Using

<div>
    @Html.ActionLink("戻る", "Index")
</div>

@Section Scripts 
    @Scripts.Render("~/bundles/jqueryval")
End Section
