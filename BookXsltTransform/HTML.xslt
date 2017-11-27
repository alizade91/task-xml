<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
    xmlns:ts="http://library.by/catalog"
>
	<xsl:output method="html" indent="yes"/>

	<xsl:key name="group" match="ts:book" use="ts:genre"/>

	<xsl:template match="ts:catalog">
		<html>
			<head>
				<title>Books</title>
			</head>
			<body>
				<xsl:apply-templates select="ts:book[generate-id(.) = generate-id(key('group', ts:genre))]"/>
				<h2>
					Total count: <xsl:value-of select="count(ts:book)"/>
				</h2>
			</body>
		</html>
	</xsl:template>

	<xsl:template match="ts:book">
		<h2>
			Genre: <xsl:value-of select="ts:genre"/>
		</h2>
		<table>
			<tr>
				<td>Author</td>
				<td>Title</td>
				<td>Publish date</td>
				<td>Registration date</td>
			</tr>
			<xsl:for-each select="key('group', ts:genre)">
				<tr>
					<td>
						<xsl:value-of select="ts:author"/>
					</td>
					<td>
						<xsl:value-of select="ts:title"/>
					</td>
					<td>
						<xsl:value-of select="ts:publish_date"/>
					</td>
					<td>
						<xsl:value-of select="ts:registration_date"/>
					</td>
				</tr>
			</xsl:for-each>
		</table>
		<h3>
			Count: <xsl:value-of select="count(key('group', ts:genre))"/>
		</h3>
	</xsl:template>

</xsl:stylesheet>
