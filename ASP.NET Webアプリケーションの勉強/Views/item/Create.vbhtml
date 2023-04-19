@ModelType ASP.NET_Webアプリケーションの勉強.t_item
@Code
    ViewData("Title") = "Create"
End Code

<h2>商品追加</h2>

@Using (Html.BeginForm()) 
    @Html.AntiForgeryToken()
    
    @<div class="form-horizontal">
        <h4>商品追加</h4>
        <hr />
        @Html.ValidationSummary(True, "", New With { .class = "text-danger" })
        <div class="form-group">
            @ViewBag.japanese.item_id
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.Id, New With {.htmlAttributes = New With {.class = "form-control"}})
                @Html.ValidationMessageFor(Function(model) model.Id, "", New With {.class = "text-danger"})
            </div>
        </div>

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
                <input type="submit" value="登録" class="btn btn-default" />
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
