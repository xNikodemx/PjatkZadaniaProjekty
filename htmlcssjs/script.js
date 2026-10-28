const factButton = document.querySelector("#fact-button");
const bio = document.querySelector("#bio");

factButton.addEventListener("click", function () {
  bio.textContent = "Ta treść została zmieniona przez JavaScript.";
  factButton.textContent = "Gotowe!";
});