function isMobile() {
    return window.innerWidth <= 768; 
}

function updateView() {
    var elements = document.getElementsByClassName('cs-p');

    if (isMobile()) {
        for (var i = 0; i < elements.length; i++) {
            elements[i].style.display = 'none';
        }
    } else {
        for (var i = 0; i < elements.length; i++) {
            elements[i].style.display = 'block';
        }
    }
}
updateView();

window.addEventListener('resize', updateView);





const width = window.innerWidth;
const height = window.innerHeight;

const svg = d3.select("#background")
  .append("svg")
  .attr("width", width)
  .attr("height", height);

let mouseX = width / 2;
let mouseY = height / 2;

document.addEventListener("mousemove", (event) => {
  mouseX = event.clientX;
  mouseY = event.clientY;
});

function createElement(type) {
  const element = svg.append("circle");

  if (type === "ball") {
    element.attr("r", Math.random() * 5 + 1)
      .attr("fill", "blue");
  } else if (type === "dot") {
    element.attr("r", Math.random() * 5 + 1)
      .attr("fill", "white");
  } else if (type === "rocket") {
    element.attr("r", Math.random() * 5 + 1)
      .attr("fill", "red");
  }

  const initialX = Math.random() * width;
  const initialY = Math.random() * height;

  element.attr("cx", initialX)
    .attr("cy", initialY)
    .attr("opacity", 1);

  const dropdownDistance = 50; // Adjust for desired dropdown distance
  const angle = Math.atan2(mouseY - initialY, mouseX - initialX);

  element.transition()
    .duration(Math.random() * 5000 + 2000)
    .attr("cx", initialX + Math.cos(angle) * dropdownDistance * (Math.random() - 0.5))
    .attr("cy", initialY + Math.sin(angle) * dropdownDistance)
    .attr("opacity", 0)
    .remove();
}

setInterval(() => {
  const type = Math.random() < 0.5 ? (Math.random() < 0.5 ? "ball" : "dot") : "rocket";
  createElement(type);
}, 50);


