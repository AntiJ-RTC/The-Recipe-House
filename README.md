# The Recipe House (Final for CSI350)

This project is a Web Application that views the Recipes and Profiles. In the Recipe details page, there are comments included for each recipe.

## Getting Started

These instructions will get you a copy of the project up and running on your local machine for development and testing purposes.

### Prerequisites

In order to run this project, you will need:

* Visual Studio
* SQL Server and SSMS
* Chrome-based browser (Edge, Chrome, etc.)

### Configure database

In order to get the web application up and running, please add the database to your SQL Server.

```
1. Update the connection string in appsetting.json to your local server
2. Run update-database. The migrations should already be created.
3. Verify the Database is set up and that you can run the application.
```

## Usage

### NOTE: In order to create, edit, or delete a Recipe, Comment, or Profile, you must register and login your own account.

In the top left of the Nav Bar, next to the name of the site "The Recipe House," there is a dropdown labeled "View other profiles," which lets you view other people's profiles registered without logging in.

### Recipe Controller

When you start the application, you will be directed to the main page of the recipe controller. Here a user can add a recipe to the index. In the index it shows each recipe with it's description.

To create a recipe, you have to fill in all the fields. It won't post if you don't fill out each text field. (ImageURL, Title, Description, Ingredients, Instructions, PrepTime and CookTime).

Once you create your recipe, you can click on the "Details" button, It will show the other parts such as the Prep time and Cook time, the Ingredients, and the Directions. You can Edit the recipe the same way as creating it, or delete each recipe.

### Comment Controller

In each recipe details page, there is a section to add comments in. Initially, it will show that there are no comments.

You can add a comment by clicking the "Comment and Rate" button. Here, you can type in your comment on the recipe, give it a rating from 1-10, and select the recipe to comment on, and the user that posted the comment.

Once you created the comment, It will be displayed in the recipe details page with the user that posted it and their rating. The comments are exclusive to each recipe.

You can edit or delete the comment in the recipe page.

### Profile Controller

On the very top right corner of the page, there is a "Profile" link. Initially, the page will be blank, so you have to click on "Create New" to add your profile.

In the create page, you can input your username, bio, and profile image. Make sure to select the correct user email for your profile (It should match the email where it says "Hello [EMAIL]!", otherwise, you can't view your own profile in the index page.)

After creating your profile, you can go to the details page of your profile, or you can edit or delete the profile.

### NOTE: to add or change an image to either the recipe or profile, it takes a URL of an image. Search for the image you're looking for, then right click on the image and click on "Copy Image Link." Then paste the URL in the "ImageURL"/"ProfileImg" text box.
