async function getAll() {
    const r = await fetch('/api/Contacts');
    const d = await r.json();
    console.log(d);
}