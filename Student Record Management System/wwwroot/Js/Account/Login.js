document.addEventListener("DOMContentLoaded", function () {
    const summary = document.querySelector(".validation-summary");

    // Check if there's actually validation content
    if (summary && summary.innerText.trim().length > 0) {
        // Show the summary box
        summary.style.display = "block";

        // Add the close button only once
        if (!summary.querySelector(".close-btn")) {
            const closeBtn = document.createElement("button");
            closeBtn.type = "button";
            closeBtn.className = "close-btn";
            closeBtn.setAttribute("aria-label", "Close");
            closeBtn.innerHTML = "&times;";
            summary.appendChild(closeBtn);

            closeBtn.addEventListener("click", function () {
                summary.style.display = "none";
            });
        }
    } else {
        summary.style.display = "none";
    }
});