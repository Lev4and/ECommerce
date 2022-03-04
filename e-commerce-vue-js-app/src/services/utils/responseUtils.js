export const responseGetAsync = async (client, url, config) => {
  return (await client.get(url, config)).data
}

export const responsePostAsync = async (client, url, requestBody) => {
  return (await client.post(url, requestBody)).data
}
